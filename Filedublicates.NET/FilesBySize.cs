using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Filedublicates.NET
{
    [Serializable]
    class GroupFilesBySize : Dictionary<long, FilesWithSameLengthAndDuplicates>
    {

        public static Dictionary<long, double> readTimes = new Dictionary<long, double>();
        public static Dictionary<long, double> hashingTimes = new Dictionary<long, double>();

        private TimeSpan _elapsed;

        public TimeSpan elapsed 
        {
            get
            {
                return _elapsed;
            }
        }

        private DirectoryInfo parentDir;

        public GroupFilesBySize() { }

        public GroupFilesBySize(SerializationInfo info, StreamingContext context) : base(info, context) { }


        public GroupFilesBySize(DirectoryInfo dir, MainForm form)
        {
            this.form = form;
            this.parentDir = dir;
        }

        private Thread thread;

        public void searchFilesWithSameLengthInNewThread()
        {
            
            thread = new Thread(new ThreadStart(searchFilesWithSameLength));

            thread.Start();
            
        }

        public void searchFilesWithSameLength()
        {
            directoriesProcessed = 0;
            filesProcessed = 0;
            DateTime t0 = DateTime.Now;
            searchFilesWithSameLength(parentDir);
            _elapsed = DateTime.Now - t0;
            
            MessageBox.Show("Searching of files with the same length in "
                + parentDir + " is finished");

            form.rootTreeNodeAdded();
        }

        private void searchFilesWithSameLength(DirectoryInfo dir)
        {
                            
            foreach (var file in dir.GetFiles())
            {
                try
                {
                    this.AddFile(file);
                }
                catch (Exception e)
                {
                    Log.error(e);
                }
            }                
                        
            directoriesProcessed++;
            
            foreach (var subDir in dir.GetDirectories())
            {
                try
                {
                    searchFilesWithSameLength(subDir);
                }
                catch (Exception e)
                {
                    Log.error(e);
                }               
            }
            
        }


        public void AddFile(FileInfo file)
        {
            // Check if we can process the full file path:
            try
            {
                string fullname = file.FullName;                
            }
            catch (Exception e)
            {
                // if we cannot -- then ignore the file
                return;
            }
            long fileLength = file.Length;
            FilesWithSameLengthAndDuplicates fileList = null;
            if (this.ContainsKey(fileLength))
                fileList = this[fileLength];
            else
            {
                fileList = new FilesWithSameLengthAndDuplicates(fileLength);
                this.Add(fileLength, fileList);
                //if (needUpdate)
                    //form.rootTreeNodeAdded(fileLength);
            }
            fileList.Add(file);
            filesProcessed++;
        }

        
        public MainForm form { get; set; }

        int _directoriesProcessed;

        public int directoriesProcessed 
        {
            get
            {
                return _directoriesProcessed;
            }
            set
            {
                _directoriesProcessed = value;
                if (needUpdate)
                    form.fileProcessed();
            }
        
        }

        int _filesProcessed;

        public int filesProcessed 
        {
            get
            {
                return _filesProcessed;
            }
            set
            {
                _filesProcessed = value;
                if (needUpdate)
                    form.fileProcessed();
            }
        }

        DateTime lastUpdate = DateTime.Now;

        public bool needUpdate
        {
            get
            {
                var ms = (DateTime.Now - lastUpdate).TotalMilliseconds;
                if ( ms
                    >= 1000)
                {
                    lastUpdate = DateTime.Now;
                    return true;
                }
                return false;
            }
        }



    }
}
