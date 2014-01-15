using System;
using System.Collections.Generic;

namespace Filedublicates.NET
{
    public abstract class AbstractComparer
    {
        public abstract void detectDuplicates();        

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
                
            }
        }

    }
}
