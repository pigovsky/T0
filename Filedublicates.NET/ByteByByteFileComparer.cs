using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Filedublicates.NET
{
    public class ByteByByteFileComparer : Filedublicates.NET.AbstractComparer
    {

        private long _totalNumberOfCmpOps;
        public long totalNumberOfCmpOps
        {
            get
            {
                return _totalNumberOfCmpOps;
            }
        }

        byte[] buffer1 = new byte[Environment.SystemPageSize];
        byte[] buffer2 = new byte[Environment.SystemPageSize];
        
        long numberOfBytesRead;
        public long numberOfCmpOpPassed { get; set; }             
        
        public Dictionary<long, double> readTimes { get; set; }

        override public void detectDuplicates()
        {
            DateTime startAll = DateTime.Now;

            detectDuplicates(filesWithSameLengthAndDuplicates.filesWithSameLength);

            filesWithSameLengthAndDuplicates.elapsed = DateTime.Now - startAll;
        }

        public void detectDuplicates(FileList files)
        {            
            long fileLength = files[0].Length;

            _totalNumberOfCmpOps = files.Count *
                (files.Count - 1) * fileLength;

            numberOfCmpOpPassed = 0;

            for (int i = 0; i < files.Count - 1; i++,
                numberOfCmpOpPassed = fileLength * (2 * files.Count - i - 3) * i)
            {

                var files_i = files[i];
                if (files_i == null)
                    continue;

                long lastNumberOfCmpOpPassed = numberOfCmpOpPassed;
                FileStream f1 = files_i.OpenRead();
                FileList same = null;

                for (int j = i + 1; j < files.Count;
                    numberOfCmpOpPassed = lastNumberOfCmpOpPassed +
                    fileLength * (j - i) * 2, j++)
                {
                    var files_j = files[j];
                    if (files_j == null)
                        continue;

                    DateTime start = DateTime.Now;
                    numberOfBytesRead = 0;

                    FileStream f2 = files_j.OpenRead();

                    if (compareFiles(f1, f2))
                    {
                        if (same == null)
                        {
                            same = new FileList();
                            same.Add(files_i);
                        }
                        same.Add(files_j);
                        files[j] = null;
                    }

                    f2.Close();

                    
                    double elapsed = (DateTime.Now - start).TotalMilliseconds;

                    if (readTimes.ContainsKey(numberOfBytesRead))
                    {
                        readTimes[numberOfBytesRead] += elapsed;
                        readTimes[numberOfBytesRead] *= .5;
                    }
                    else
                    {
                        readTimes.Add(numberOfBytesRead, elapsed);
                    }
                }
                if (same != null)
                {
                    filesWithSameLengthAndDuplicates.AddDuplicate(same);
                }
                f1.Close();
            }
            numberOfCmpOpPassed = totalNumberOfCmpOps;            
        }

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);

        public bool compareFiles(FileStream f1, FileStream f2)
        {
            f1.Seek(0, SeekOrigin.Begin);
            f2.Seek(0, SeekOrigin.Begin);
            
            do
            {
                var bytesRead1 = f1.Read(buffer1, 0, buffer1.Length);
                
                numberOfBytesRead += bytesRead1;                
                numberOfCmpOpPassed += bytesRead1;

                var bytesRead2 = f2.Read(buffer2, 0, buffer2.Length);

                numberOfBytesRead += bytesRead2;
                numberOfCmpOpPassed += bytesRead2;

                if (bytesRead1 != bytesRead2)
                    return false;
                if (bytesRead1 <= 0 || bytesRead2 <= 0) // EOF
                    break; 
                if (memcmp(buffer1, buffer2, bytesRead1) != 0)
                    return false;
            } while (true);

            return true;
        }
    }
}
