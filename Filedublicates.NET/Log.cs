using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filedublicates.NET
{
    public class Log
    {
        private static TextWriter _logFile = null;

        private static TextWriter logFile
        {
            get
            {
                if (_logFile == null)
                    _logFile = File.CreateText(@"C:\HOME\Jurgen\log.txt");
                return _logFile;
            }            
        }

        public static void error(Exception e)
        {
            string msg = e.ToString();
            //MessageBox.Show(msg);
            logFile.WriteLine(msg);
        }
    }
}
