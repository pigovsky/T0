using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    _logFile = File.CreateText("log.txt");
                return _logFile;
            }            
        }

        public static void error(Exception e)
        {
            logFile.WriteLine(e.ToString());
        }
    }
}
