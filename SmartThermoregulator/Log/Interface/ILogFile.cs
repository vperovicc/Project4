using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Interface
{
    public interface ILogFile
    {
        void LogInFile(string message);
    }
}
