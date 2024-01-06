using Heater.Interface;
using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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

        private Heater Grejac { get; set; }
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

            Grejac = new Heater();

        }



     
        public async void Regulation()
        {
            for (int i = 0; i <= InstanceCnt; i++)
            {
                
                string stringConn = "tcp://localhost:" + (8500 + port[i]).ToString() + "/Device";
                Device.Device mr = RemotingServices.Connect(typeof(Device.Device), stringConn) as Device.Device;

                Uredjaji.Add(mr);
            }

            await CheckWork();
        }


        public async Task CheckWork()
        {
            CancellationToken ct = new CancellationToken();
            TimeSpan time = new TimeSpan(0, 0, 5); 
            Grejac.Devices = Uredjaji; 

            for (; !ct.IsCancellationRequested;)
            {
                await PeriodicnaProvera(time, ct);

                CheckTempHeater();
            }
        }


        private void AverageTemp()
        {
            double suma = 0.0;

            foreach (Device.Device device in Uredjaji)
            {
                suma += device.Temperature;
            }

            ProsecnaTemperatura = suma / Uredjaji.Count;
        }


        private void CheckTempHeater()
        {
            
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            int currentHour = currentTime.Hours;

            if (currentHour >= PocetakDnevniRezim && currentHour <= KrajDnevniRezim)
            {
                JeDnevniRezim = true;
                JeNocniRezim = false;
            }
            else
            {
                JeDnevniRezim = false;
                JeNocniRezim = true;
            }

            
            AverageTemp();

          
            if (JeDnevniRezim)
            {
                if (ProsecnaTemperatura < ZeljenaDnevnaTemperatura)
                {
                    if (!ukljucena)
                    {
                        Log log = new Log("Ukljucivanje centralne peci!");
                        log.NewMessage();

                        
                        isklucena = false;
                        ukljucena = true;
                    }

                    // ukljucivanje grejaca
                    Grejac.IsHeaterOn = true;
                }
                else
                {
                    if (!isklucena)
                    {
                        Log log = new Log("Centralna  pec je  iskljucena!");
                        log.NewMessage();

                        
                        ukljucena = false;
                        isklucena = true;
                    }

                    // gasenje grejaca
                    Grejac.IsHeaterOn = false;
                }
            }
            else if (JeNocniRezim)
            {
                if (ProsecnaTemperatura < ZeljenaNocnaTemperatura)
                {
                    Log log = new Log("Ukljucivanje centralne peci!");
                    log.NewMessage();

                    
                    Grejac.IsHeaterOn = true;
                }
                else
                {
                    Log log = new Log("Centralna pec je iskljucena!");
                    log.NewMessage();

                    
                    Grejac.IsHeaterOn = false;
                }
            }
            else
            {
                Log log = new Log("Greska sa centralnom peci!");
                log.NewError();

                
                Grejac.IsHeaterOn = false;
            }

            Grejac.StartHeatingProcess(); // pokretanje grejaca
        }



        public async Task PeriodicnaProvera(TimeSpan interval, CancellationToken cancellationToken)
        {
            await Task.Delay(interval, cancellationToken);
        }

    }
}
