using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Interface
{
    public interface ILog
    {
        void NewMessage();
        void NewWarning();
        void NewError();
    }
}
