using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Filedublicates.NET
{
    delegate string ComputeHash(FileInfo file);

    class GroupFilesByHash : Dictionary<string, FileList>, IGroupFiles
    {
        static SHA1 sha1 = SHA1.Create();

        ComputeHash computeHash = null;

        public static string computeSHA1(FileInfo file)
        {
            var fd = file.OpenRead();
            string hashValue = Convert.ToBase64String(sha1.ComputeHash(fd));
            fd.Close();
            return hashValue;
        }

        public GroupFilesByHash(ComputeHash computeHash)
        {
            this.computeHash = computeHash;
        }

        public void AddFile(FileInfo file)
        {
            string hashValue = computeHash(file);
            FileList fileList = null;
            if (this.ContainsKey(hashValue))
                fileList = this[hashValue];
            else
            {
                fileList = new FileList();
                this.Add(hashValue, fileList);
                //if (needUpdate)
                //form.rootTreeNodeAdded(fileLength);
            }
            fileList.Add(file);
        }

        private TimeSpan _elapsed;

        public TimeSpan elapsed
        {
            get
            {
                return _elapsed;
            }
        }
    }
}
