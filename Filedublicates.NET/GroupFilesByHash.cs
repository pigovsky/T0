using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Filedublicates.NET
{
    public class GroupFilesByHash : Dictionary<string, FileList>
    {
        public Dictionary<long, double> hashingTimes { get; set; }
        public long bytesHashed { get; set; }
        public static SHA1 sha1 = SHA1.Create();
        public static MD5 md5 = MD5.Create();
        public HashAlgorithm hashAlgorithm = md5;

        public long totalNumberOfBytesToBeHashed { get; set; }    

        private string computeHash(FileInfo file)
        {
            var fd = file.OpenRead();
            string hashValue = Convert.ToBase64String(hashAlgorithm.ComputeHash(fd));
            fd.Close();
            return hashValue;
        }

        private void AddFile(FileInfo file)
        {
            string hashValue = computeHash(file);
            FileList fileList = null;
            if (this.ContainsKey(hashValue))
                fileList = this[hashValue];
            else
            {
                fileList = new FileList();
                this.Add(hashValue, fileList);                
            }
            fileList.Add(file);

            bytesHashed += file.Length;
        }

        private TimeSpan _elapsed;

        public void hashFiles(FileList fileList)
        {            
            DateTime allStart = DateTime.Now;
            bytesHashed = 0;
            totalNumberOfBytesToBeHashed = fileList.Count * fileList[0].Length;
            foreach (var file in fileList)
            {
                DateTime start = DateTime.Now;
                AddFile(file);
                double e = (DateTime.Now - start).TotalMilliseconds;
                if (hashingTimes.ContainsKey(file.Length))
                {
                    hashingTimes[file.Length] += e;
                    hashingTimes[file.Length] *= .5;
                }
                else
                {
                    hashingTimes.Add(file.Length, e);
                }
            }
            _elapsed = DateTime.Now - allStart;
        }

        public TimeSpan elapsed
        {
            get
            {
                return _elapsed;
            }
        }
    }
}
