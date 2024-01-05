using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Log
{
    public class LogFile
    {
        private string fileName = "log.txt";

        public LogFile(string fn = "log.txt")
        {
            if (fileName == null)
            {
                throw new ArgumentNullException();
            }

            if (fileName.Trim().Length == 0)
            {
                throw new ArgumentException();
            }

            fileName = fn;
        }

        public void LogInFile(string mess)
        {
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine(mess);
            }
        }
    }
}
