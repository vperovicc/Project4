﻿using Log.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Implementation
{
    public class Log : ILog
    {

        private string message;
        LogMessage lm = null;
        LogFile lf = null;

        public Log(string mess)
        {
            if(message == null)
            {
                throw new ArgumentNullException();
            }

            if(message.Trim().Length == 0)
            {
                throw new ArgumentException();
            }    

            message = mess;

            lm = new LogMessage(message);
        }

        public string Message_for_File
        {
            get => message; 
            set => message = value;
        }

        public void NewError()
        {
            lf= new LogFile("log.txt");
            lf.LogInFile(lm.GetError());
        }

        public void NewMessage()
        {
            lf = new LogFile("log.txt");
            lf.LogInFile(lm.GetMessage());
        }

        public void NewWarning()
        {
            lf = new LogFile("log.txt");
            lf.LogInFile(lm.GetWarning());
        }
    }
}
