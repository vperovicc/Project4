using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class LogMessage
    {
        private string message;

        public LogMessage(string mess)
        {
            if (mess == null)
            {
                throw new ArgumentNullException();
            }

            if (mess.Trim().Length == 0)
            {
                throw new ArgumentException();
            }

            message = mess;
        }

        public string GetMessage()
        {
            return string.Format("[INFORMATION] [{0}] {1}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), message);
        }

        public string GetWarning()
        {
            return string.Format("[WARNING] [{0}] {1}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), message);
        }

        public string GetError()
        {
            return string.Format("[ERROR] [{0}] {1}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), message);
        }
    }
}
