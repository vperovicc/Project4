using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Interface
{
    public interface ILogMessage
    {
        string GetMessage();
        string GetWarning();
        string GetError();
    }
}
