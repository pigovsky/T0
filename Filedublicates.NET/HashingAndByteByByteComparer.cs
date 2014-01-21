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

        

        

        override public void detectDuplicates()
        {
            DateTime startAll = DateTime.Now;
            var groupFilesByHash = new GroupFilesByHash() { hashingTimes = GroupFilesBySize.hashingTimes };
            groupFilesByHash.searchingDuplicatesProgressDialog = this.searchingDuplicatesProgressDialog;
            searchingDuplicatesProgressDialog.totalNumberOfBytesToBeHashed =
                filesWithSameLengthAndDuplicates.filesWithSameLength.Count * filesWithSameLengthAndDuplicates.fileLength;
            groupFilesByHash.hashFiles(filesWithSameLengthAndDuplicates.filesWithSameLength);
            
            byteByByteFileComparer.filesWithSameLengthAndDuplicates = this.filesWithSameLengthAndDuplicates;

            searchingDuplicatesProgressDialog.numberOfHashGroupIndexes = groupFilesByHash.Count;
            searchingDuplicatesProgressDialog.hashGroupIndex = 0;
            foreach (var hashGroup in groupFilesByHash)
            {
                if (searchingDuplicatesProgressDialog.stop)
                {
                    break;
                }
                byteByByteFileComparer.detectDuplicates(hashGroup.Value);
                searchingDuplicatesProgressDialog. hashGroupIndex++;
            }

            filesWithSameLengthAndDuplicates.filesWithSameLength = null;
            filesWithSameLengthAndDuplicates.processedUsingAlgorithm = ProcessAlgorithm.HASHING_AND_BYTE_BY_BYTE;
            filesWithSameLengthAndDuplicates.elapsed = DateTime.Now - startAll;            
        }
    }
}
