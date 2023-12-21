using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Device.Implementation;
using Device.Interface;

namespace Device.Implementation
{
    public class PeriodicTimer : IPeriodicTimer
    {
        public async Task PeriodicnaProvera(TimeSpan i, CancellationToken c)
        {
            await Task.Delay(i, c);
        }

        public async Task SlanjeMerenja(int id, double t)
        {
            CancellationToken ct = new CancellationToken();
            TimeSpan time = new TimeSpan(0, 3, 0);

            for (; !ct.IsCancellationRequested;)
            {
                await PeriodicnaProvera(time, ct);
            }
        }
    }
}
