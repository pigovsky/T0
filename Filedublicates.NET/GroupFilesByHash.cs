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

        public SearchingDuplicates searchingDuplicatesProgressDialog { get; set; }
        public Dictionary<long, double> hashingTimes { get; set; }
        
        public static SHA1 sha1 = SHA1.Create();
        public static MD5 md5 = MD5.Create();
        public HashAlgorithm hashAlgorithm = md5;

        private string computeHash(FileInfo file)
        {
            searchingDuplicatesProgressDialog.currentFileBeingHeshed =
                file.FullName;

            FileStream fd = null;
            string hashValue = null;
            try
            {
                fd = file.OpenRead();
                hashValue = Convert.ToBase64String(hashAlgorithm.ComputeHash(fd));
            }
            catch (Exception e)
            {
                Log.error(e);
            }
            finally
            {
                if (fd != null)
                {
                    fd.Close();
                }
            }
            
            return hashValue;
        }

        private void AddFile(FileInfo file)
        {
            DateTime start = DateTime.Now;
            string hashValue = computeHash(file);
            if (hashValue == null)
            {
                return;
            }
            FileList fileList = null;
            if (this.ContainsKey(hashValue))
                fileList = this[hashValue];
            else
            {
                fileList = new FileList();
                this.Add(hashValue, fileList);                
            }
            fileList.Add(file);

            searchingDuplicatesProgressDialog.bytesHashed += file.Length;
            searchingDuplicatesProgressDialog.numberOfHashedFiles++;

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

        private TimeSpan _elapsed;

        public void hashFiles(FileList fileList)
        {            
            DateTime allStart = DateTime.Now;
            searchingDuplicatesProgressDialog.numberOfFilesToBeHashed = fileList.Count;
            searchingDuplicatesProgressDialog.numberOfHashedFiles = 0;
            searchingDuplicatesProgressDialog.bytesHashed = 0;
            
            foreach (var file in fileList)
            {
                if (searchingDuplicatesProgressDialog.stop)
                {
                    break;
                }
                
                AddFile(file);
                
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
