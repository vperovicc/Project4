using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Device.Interface
{
    public interface IPeriodicTimer
    {
        Task SlanjeMerenja(int id, double t);
        Task PeriodicnaProvera(TimeSpan i, CancellationToken c);
    }
}
