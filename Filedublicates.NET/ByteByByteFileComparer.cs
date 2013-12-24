using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Filedublicates.NET
{
    class ByteByByteFileComparer
    {
        static byte[] buffer1 = new byte[Environment.SystemPageSize];
        static byte[] buffer2 = new byte[Environment.SystemPageSize];

        static void detectDuplicates(FileList files, List<FileList> duplicates)
        {
            for (int i = 0; i < files.Count; i++)
            {
                var files_i = files[i]; 
                if (files_i == null)
                    continue;
                FileStream f1 = files_i.OpenRead();
                FileList same = null;
                
                for (int j = i+1; j < files.Count; j++)
                {
                    var files_j = files[j];
                    if (files_j == null)
                        continue;
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
                }
                if (same != null)
                    duplicates.Add(same);

                f1.Close();
            }
        }

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);

        static public bool compareFiles(FileStream f1, FileStream f2)
        {
            f1.Seek(0, SeekOrigin.Begin);
            f2.Seek(0, SeekOrigin.Begin);
            
            do
            {
                var bytesRead1 = f1.Read(buffer1, 0, buffer1.Length);
                var bytesRead2 = f2.Read(buffer2, 0, buffer2.Length);
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
