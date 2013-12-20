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
        FilesBySize filesWithSameLength;

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
                var sortedDict = from entry in filesWithSameLength where entry.Value.Count>1 orderby entry.Value.Count descending, entry.Key ascending select entry;
                //MessageBox.Show(filesWithSameLength.Count.ToString());
                treeView1.Nodes.Clear();
                foreach (var entry in sortedDict)
                {                                      
                    var tn = new TreeNode();
                    tn.Tag = entry.Key;
                    tn.Text = ""+ entry.Value.Count+ " files of " + entry.Key + " bytes";
                    treeView1.Nodes.Add(tn);
                    foreach (var file in entry.Value)
                        tn.Nodes.Add(file.FullName);                                          
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            DirectoryInfo dir = 
                new FileInfo(ofd.FileName).Directory;
            filesWithSameLength = new FilesBySize(dir, this);

            toolStripStatusLabel1.Text = "files are being searched in "+dir;

            filesWithSameLength.searchFilesWithSameLengthInNewThread();
        }

        private void saveInfoAboutFilesWithSameLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.fs";
            sfd.ShowDialog();
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
            ofd.ShowDialog();
            string filename = ofd.FileName;
            // Restore from file
            FileStream stream = File.OpenRead(filename);
            
            filesWithSameLength = (FilesBySize)formatter.Deserialize(stream);
            stream.Close();

            rootTreeNodeAdded();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start("notepad.exe", treeView1.SelectedNode.Text);
        }
    }
}
