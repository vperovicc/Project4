using Database.Implementation;
using Database.Interface;
using Heater.Interface;
using Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
    public class Heater : IHeater
    {

        public bool IsHeaterOn { get; set; }
        Stopwatch ElapsedTime { get; set; }
        public List<Device.Device> Devices { get; set; }
        public Heater()
        {
            IsHeaterOn = false;
            ElapsedTime = new Stopwatch();
        }

        public void StartHeatingProcess()
        {
            if (IsHeaterOn) 
            {

                ElapsedTime.Start();

                var prosecna = 0.0;
                foreach (Device.Device d in Devices)
                {
                    d.Temperature += 5.02;
                    prosecna += d.Temperature;

                    string r = string.Format("Uredjaj [{0}]: Temperatura: {1}°C", d.DeviceID, d.Temperature);
                    Log l = new Log(r);
                    l.NewMessage();
                }

                string str = string.Format("Prosecna temperatura: {0}°C", prosecna / Devices.Count);
                Log log = new Log(str);
                log.NewMessage();
            }
            else
            {
                ElapsedTime.Stop(); 
                Evidention();
                IsHeaterOn = false;
                ElapsedTime.Reset(); 
            }
        }

        public void Evidention()
        {
            try
            {
                IWriteHeaterData upisPodataka = new WriteHeaterData();

                var ts = ElapsedTime.Elapsed;
                int proteklo = ts.Milliseconds;
                string datum = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                decimal potroseno = proteklo * 14; 

                upisPodataka.EvidencijaRada(proteklo, datum, potroseno);
            }
            catch (Exception )
            {
                //
            }
        }
    }
}
