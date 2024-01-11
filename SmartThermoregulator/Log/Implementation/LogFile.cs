using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logging
{
    public class LogFile
    {
        private string fileName = "C:/Users/vukas/OneDrive/Радна површина/aaa_kraj/SmartThermoregulator/log.txt";

        public LogFile(string fn = "C:/Users/vukas/OneDrive/Радна површина/aaa_kraj/SmartThermoregulator/log.txt")
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
