using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Interface
{
    public interface IWriteHeaterData
    {
        bool EvidencijaRada(int radniSati, string datum, decimal potrosnjaKw);

    }
}
