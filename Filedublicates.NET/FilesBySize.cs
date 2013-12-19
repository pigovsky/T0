using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Filedublicates.NET
{
    class FilesBySize : Dictionary<long, FileList>
    {
        public TimeSpan elapsed { get; set; }

        private DirectoryInfo parentDir;

        public FilesBySize(DirectoryInfo dir, Form1 form)
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
            elapsed = DateTime.Now - t0;
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
            FileList fileList = null;
            if (this.ContainsKey(file.Length))
                fileList = this[file.Length];
            else
            {
                fileList = new FileList();
                this.Add(file.Length, fileList);
                if (form.needUpdate)
                    form.rootTreeNodeAdded();
            }
            fileList.Add(file);
            filesProcessed++;
        }

        public Form1 form { get; set; }

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
                if (form.needUpdate)
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
                if (form.needUpdate)
                    form.fileProcessed();
            }
        }
    }
}
