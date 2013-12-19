using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        DateTime lastUpdate = DateTime.Now;

        public bool needUpdate
        {
            get
            {
                if ((DateTime.Now - lastUpdate).Milliseconds
                    >= 1000)
                {
                    lastUpdate = DateTime.Now;
                    return true;
                }
                return false;
            }
        }

        public void rootTreeNodeAdded()
        {            
            if (treeView1.InvokeRequired)
                Invoke(new ThreadStart(rootTreeNodeAdded));
            else
            {
                //MessageBox.Show(filesWithSameLength.Count.ToString());
                treeView1.Nodes.Clear();
                foreach (var key in filesWithSameLength.Keys)
                {
                    treeView1.Nodes.Add(
                        new TreeNode(key.ToString()));
                    //MessageBox.Show(key.ToString());
                }
                treeView1.Update();
            }
        }

        public void fileProcessed()
        {            
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
    }
}
