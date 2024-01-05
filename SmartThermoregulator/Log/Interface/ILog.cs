using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Interface
{
    public interface ILog
    {
        void NewMessage();
        void NewWarning();
        void NewError();
    }
}
