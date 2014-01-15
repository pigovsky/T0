using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filedublicates.NET
{
    public class FilesWithSameLengthAndDuplicates
    {
        public FileList filesWithSameLength { get; set; }

        public void Add(FileInfo f)
        {
            if (filesWithSameLength == null)
                filesWithSameLength = new FileList();
            filesWithSameLength.Add(f);
            _numberOfFilesWithSameLength++;
        }

        private long _numberOfFilesWithSameLength = 0;
        public long numberOfFilesWithSameLength
        {
            get
            {
                return _numberOfFilesWithSameLength;
            }
        }

        public TimeSpan elapsed { get; set; }

        public List<FileList> duplicates { get; set; }

        public void populateTreeNode(TreeNode tn)
        {
            tn.Nodes.Clear();
            if (duplicates == null)
            {                
                foreach (var file in filesWithSameLength)
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
            else 
            {
                long i = 0;
                foreach (var duplicateFiles in duplicates)
                {
                    var duplicateFilesNode = new TreeNode();
                    duplicateFilesNode.Tag = duplicateFiles;
                    duplicateFilesNode.Text = "" + duplicateFiles.Count +
                        " files with content #" + i;
                    duplicateFilesNode.Nodes.Add("stub");
                    tn.Nodes.Add(duplicateFilesNode);
                }
            }
        }

        internal void AddDuplicate(FileList same)
        {
            if (duplicates == null)
            {
                duplicates = new List<FileList>();
            }
            duplicates.Add(same);
        }
    }
}
