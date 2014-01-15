using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filedublicates.NET
{
    public partial class Form1 : Form
    {
        GroupFilesBySize filesWithSameLength;

        delegate void rootTreeNodeAddedCallback(long key);

        public void rootTreeNodeAdded(long key)
        {
            if (treeView1.InvokeRequired)
                Invoke(new rootTreeNodeAddedCallback(rootTreeNodeAdded));
            else
            {                
                var tn = new TreeNode();
                tn.Tag = key;
                tn.Text = key.ToString();
                treeView1.Nodes.Add(tn);                    
            }
        }


        public void rootTreeNodeAdded()
        {            
            if (treeView1.InvokeRequired)
                Invoke(new ThreadStart(rootTreeNodeAdded));
            else
            {
                var sortedDict = (from entry in filesWithSameLength where entry.Value.filesWithSameLength.Count>1 orderby entry.Value.filesWithSameLength.Count descending, entry.Key ascending select entry).Take(100);
                //MessageBox.Show(filesWithSameLength.Count.ToString());
                treeView1.Nodes.Clear();
                foreach (var entry in sortedDict)
                {                                      
                    var tn = new TreeNode();
                    tn.Tag = entry.Key;
                    tn.Text = ""+ entry.Value.filesWithSameLength.Count+ " files of " + entry.Key + " bytes";
                    treeView1.Nodes.Add(tn);
                    tn.Nodes.Add("stub");                  
                }
                
            }
        }

        public void fileProcessed()
        {
            //MessageBox.Show("File is processed");
            if (statusStrip1.InvokeRequired)
                Invoke(new ThreadStart(fileProcessed));
            else
            {
                toolStripStatusLabel1.Text = "" +
                    filesWithSameLength.directoriesProcessed +
                    " directories have been processed" +
                    filesWithSameLength.filesProcessed +
                    " files have been processed";
            }
        }

        public Form1()
        {
            InitializeComponent();
            hashingAndByteByByteComparer.byteByByteFileComparer = byteByByteFileComparer;
            hashingAndByteByByteComparer.groupFilesByHash = groupFilesByHash;
        }

        private void searchFilesWithSameLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            DirectoryInfo dir = 
                new DirectoryInfo(ofd.SelectedPath);
            filesWithSameLength = new GroupFilesBySize(dir, this);

            toolStripStatusLabel1.Text = "files are being searched in "+dir;

            filesWithSameLength.searchFilesWithSameLengthInNewThread();
        }

        private void saveInfoAboutFilesWithSameLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.fs";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            
            string filename = sfd.FileName;
            // Persist to file
            FileStream stream = File.Create(filename);
                       
            formatter.Serialize(stream, filesWithSameLength);
            stream.Close();            
        }

        BinaryFormatter formatter = new BinaryFormatter();

        private void loadInfoAboutFilesWithSameLengthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "*.fs";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            string filename = ofd.FileName;
            // Restore from file
            FileStream stream = File.OpenRead(filename);
            
            filesWithSameLength = (GroupFilesBySize)formatter.Deserialize(stream);
            stream.Close();

            rootTreeNodeAdded();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(treeView1.SelectedNode.Tag is FileInfo))
                return;
            FileInfo file = (FileInfo) treeView1.SelectedNode.Tag;
            Environment.CurrentDirectory = file.Directory.FullName;
            Process.Start("notepad.exe", file.Name);
        }

        

        private void exportInfoAboutFilesWithSameLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.sce";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            var sortedDict = from entry in filesWithSameLength where entry.Value.numberOfFilesWithSameLength > 1 orderby entry.Value.numberOfFilesWithSameLength ascending, entry.Key ascending select entry;

            var file = File.CreateText(sfd.FileName);

            file.WriteLine("files = [\n" +
                "//\t Number of files\t file length\t Time to find duplicates, sec."+
                "\t Number of duplicate groups");

            foreach (var entry in sortedDict)
            {
                file.WriteLine("\t" + entry.Value.filesWithSameLength.Count + "\t"+
                    entry.Key+"\t"+entry.Value.elapsed.TotalSeconds+"\t"+
                    entry.Value.duplicates.Count);
            }
            file.WriteLine("];");
            file.WriteLine("// Files with same length were found in " +
                            filesWithSameLength.elapsed.TotalSeconds
                            + " seconds");
            
            WriteTimeMeasurementsToFile(file, "readingTimes", readTimes);
            WriteTimeMeasurementsToFile(file, "hashingTimes", hashingTimes);
            

            
            
            file.Close();
        }

        private static void WriteTimeMeasurementsToFile(StreamWriter file, string table, Dictionary<long, double> timeMeasurements)
        {
            file.WriteLine(table + " = [");
            file.WriteLine("//\tBytes\tMilliseconds");
            foreach (var entry in timeMeasurements)
                file.WriteLine("\t" + entry.Key + "\t" + entry.Value);
            file.WriteLine("]");
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode tn = e.Node;

            if (tn.Tag is long)
            {
                long fileSize = (long)tn.Tag;
                var filesGroup = filesWithSameLength[fileSize];
                filesGroup.populateTreeNode(tn);
            }
            else if (tn.Tag is FileList)
            {
                var duplicateFiles = (FileList)tn.Tag;
                tn.Nodes.Clear();
                foreach (var file in duplicateFiles)
                {
                    var fn = new TreeNode();
                    fn.Tag = file;                   
                    fn.Text = file.FullName;
                    tn.Nodes.Add(fn);
                }
            }
        }

        static Dictionary<long, double> readTimes = new Dictionary<long,double>();
        static Dictionary<long, double> hashingTimes = new Dictionary<long,double>();
        

        public ByteByByteFileComparer byteByByteFileComparer = new ByteByByteFileComparer { readTimes = readTimes };
        private GroupFilesByHash groupFilesByHash = new GroupFilesByHash() { hashingTimes = hashingTimes };
        
        public HashingAndByteByByteComparer hashingAndByteByByteComparer = new HashingAndByteByByteComparer();

        SearchingDuplicates sd;

        private bool doCompare(AbstractComparer ac)
        {
            if (!(treeView1.SelectedNode.Tag is long))
                return false;

            long fileSize = (long)treeView1.SelectedNode.Tag;
            ac.filesWithSameLengthAndDuplicates = filesWithSameLength[fileSize];

            sd = new SearchingDuplicates(this);

            Thread th = new Thread(new
                ThreadStart(ac.detectDuplicates));
            th.Start();

            sd.ShowDialog();

            return true;
        }

        private void byteByByteComparsionToolStripMenuItem_Click(object sender, EventArgs e)
        {                                           
            doCompare(byteByByteFileComparer);
        }

        private void hashingByteByByteComparsionToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            doCompare(hashingAndByteByByteComparer);
        }
    }
}
