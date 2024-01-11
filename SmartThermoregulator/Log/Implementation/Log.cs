using Logging.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class Log : ILog
    {

        private string message;
        LogMessage lm = null;
        LogFile lf = null;

        public Log(string mess)
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

            lm = new LogMessage(message);
        }

        public string Message
        {
            get => message;
            set => message = value;
        }

        public void NewError()
        {
            lf = new LogFile("C:/Users/vukas/OneDrive/Радна површина/aaa_kraj/SmartThermoregulator/log.txt");
            lf.LogInFile(lm.GetError());
        }

        public void NewMessage()
        {
            lf = new LogFile("C:/Users/vukas/OneDrive/Радна површина/aaa_kraj/SmartThermoregulator/log.txt");
            lf.LogInFile(lm.GetMessage());
        }

        public void NewWarning()
        {
            lf = new LogFile("C:/Users/vukas/OneDrive/Радна површина/aaa_kraj/SmartThermoregulator/log.txt");
            lf.LogInFile(lm.GetWarning());
        }
    }
}
