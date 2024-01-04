using Heater.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Heater
{
   public class Regulator : IRegulator
    {

        private int[] port = new int[100];

        public double ZeljenaDnevnaTemperatura { get; set; }
        public double ZeljenaNocnaTemperatura { get; set; }
        public double ProsecnaTemperatura { get; set; }
        public int PocetakDnevniRezim { get; set; }
        public int KrajDnevniRezim { get; set; }
        public bool JeNocniRezim { get; set; }
        public bool JeDnevniRezim { get; set; }
        public List<Device.Device> Uredjaji { get; set; }

        public int InstanceCnt { get; set; }

        private bool isklucena = false;
        private bool ukljucena = false;

        public Regulator()
        {

            ZeljenaDnevnaTemperatura = 0;
            ZeljenaNocnaTemperatura = 0;
            ProsecnaTemperatura = 0;
            InstanceCnt = 0;
            JeNocniRezim = false;
            JeDnevniRezim = false;


        }

        public async Task PeriodicnaProvera(TimeSpan interval, CancellationToken cancellationToken)
        {
            await Task.Delay(interval, cancellationToken);
        }

        public void Regulisanje()
        {
            throw new NotImplementedException();
        }
    }
}
