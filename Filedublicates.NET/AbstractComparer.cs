using System;
using System.Collections.Generic;

namespace Filedublicates.NET
{
    public abstract class AbstractComparer : Filedublicates.NET.IAbstractComparer
    {
        
        protected void calculateTotalNumberOfCmpOps(FileList files)
        {            
            _totalNumberOfCmpOps = files.Count *
                (files.Count - 1) * filesWithSameLengthAndDuplicates.fileLength;
        }

        private long _totalNumberOfCmpOps;
        public long totalNumberOfCmpOps
        {
            get
            {
                return _totalNumberOfCmpOps;
            }
        }

        private FilesWithSameLengthAndDuplicates _filesWithSameLengthAndDuplicates;
        public FilesWithSameLengthAndDuplicates filesWithSameLengthAndDuplicates
        {
            get
            {
                return _filesWithSameLengthAndDuplicates;
            }
            set
            {
                _filesWithSameLengthAndDuplicates = value;
                calculateTotalNumberOfCmpOps(_filesWithSameLengthAndDuplicates.filesWithSameLength);
            }
        }

    }
}
