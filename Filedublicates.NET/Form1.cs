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
                var sortedDict = (from entry in filesWithSameLength where entry.Value.Count>1 orderby entry.Value.Count descending, entry.Key ascending select entry).Take(100);
                //MessageBox.Show(filesWithSameLength.Count.ToString());
                treeView1.Nodes.Clear();
                foreach (var entry in sortedDict)
                {                                      
                    var tn = new TreeNode();
                    tn.Tag = entry.Key;
                    tn.Text = ""+ entry.Value.Count+ " files of " + entry.Key + " bytes";
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
            FileInfo file = (FileInfo) treeView1.SelectedNode.Tag;
            Environment.CurrentDirectory = file.Directory.FullName;
            Process.Start("notepad.exe", file.Name);
        }

        private void exportInfoAboutFilesWithSameLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.m";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            var sortedDict = from entry in filesWithSameLength where entry.Value.Count > 1 orderby entry.Value.Count ascending, entry.Key ascending select entry;

            var file = File.CreateText(sfd.FileName);

            file.WriteLine("files = [\n" +
                "\t% Number of files\t file length");

            foreach (var entry in sortedDict)
                file.WriteLine("\t" + entry.Value.Count + "\t" + entry.Key);
            file.WriteLine("];");
            file.WriteLine("% Files with same length were found in " +
                            filesWithSameLength.elapsed.TotalMilliseconds
                            + " milliseconds");
            file.Close();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode tn = e.Node;
            tn.Nodes.Clear();

            foreach (var file in filesWithSameLength[(long)tn.Tag])
            {
                var fn = new TreeNode();
                fn.Tag = file;
                try
                {
                    fn.Text = file.FullName;
                }
                catch (Exception err)
                {
                    fn.Text = "crazy-long file path...";
                }
                tn.Nodes.Add(fn);
            }
        }
    }
}
