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
        byte[] buffer1 = new byte[Environment.SystemPageSize];
        byte[] buffer2 = new byte[Environment.SystemPageSize];

        public FileStream f1 {get; set;}
        public FileStream f2 { get; set; }

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);
        
        public bool compareFiles()
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
