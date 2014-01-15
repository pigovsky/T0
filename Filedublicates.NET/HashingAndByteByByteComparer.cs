using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filedublicates.NET
{
    public class HashingAndByteByByteComparer : AbstractComparer
    {

        public ByteByByteFileComparer byteByByteFileComparer { get; set; }

        public GroupFilesByHash groupFilesByHash { get; set; }

        public long hashGroupIndex { get; set; }

        override public void detectDuplicates()
        {
            DateTime startAll = DateTime.Now;

            groupFilesByHash.hashFiles(filesWithSameLengthAndDuplicates.filesWithSameLength);
            
            byteByByteFileComparer.filesWithSameLengthAndDuplicates = this.filesWithSameLengthAndDuplicates;

            hashGroupIndex = 0;
            foreach (var hashGroup in groupFilesByHash)
            {
                
                byteByByteFileComparer.detectDuplicates(hashGroup.Value);
                hashGroupIndex++;
            }

            filesWithSameLengthAndDuplicates.elapsed = DateTime.Now - startAll;            
        }
    }
}
