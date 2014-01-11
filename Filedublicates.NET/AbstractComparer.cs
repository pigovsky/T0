using System;
using System.Collections.Generic;

namespace Filedublicates.NET
{
    public abstract class AbstractComparer
    {
        public abstract void detectDuplicates();

        public long fileLength { get; set; }

        private FileList _files;
        public FileList files
        {
            get
            {
                return _files;
            }
            set
            {
                _files = value;
                fileLength = _files[0].Length;
            }
        }

        public Dictionary<long, double> totalTimeElapsed { get; set; }
    }
}
