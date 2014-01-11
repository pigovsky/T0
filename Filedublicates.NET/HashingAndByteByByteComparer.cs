using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filedublicates.NET
{
    public class HashingAndByteByByteComparer : Filedublicates.NET.AbstractComparer
    {
        public ByteByByteFileComparer byteByByteFileComparer { get; set; }
        public GroupFilesByHash groupFilesByHash { get; set; }

        public long hashGroupIndex { get; set; }

        override public void detectDuplicates()
        {
            DateTime startAll = DateTime.Now;

            groupFilesByHash.hashFiles(files);

            hashGroupIndex = 0;
            foreach (var hashGroup in groupFilesByHash)
            {
                byteByByteFileComparer.files = hashGroup.Value;
                byteByByteFileComparer.detectDuplicates();
                hashGroupIndex++;
            }

            if (totalTimeElapsed != null)
            {
                totalTimeElapsed.Add(byteByByteFileComparer.fileLength, 
                    (DateTime.Now - startAll).TotalSeconds);
            }
        }
    }
}
