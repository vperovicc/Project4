using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterTests
{
    [TestFixture]
    public class HeatTests
    {

        [Test]
        [TestCase()]
        public void ConstrucotorOkay()
        {
            Heater.Heater h1 = new Heater.Heater();
            Heater.Heater h2 = new Heater.Heater();

            Assert.AreEqual(h1.IsHeaterOn, h2.IsHeaterOn);
        }



        [Test]
        [TestCase()]
        public void StartHeat()
        {
            Heater.Heater h = new Heater.Heater();
            Device.Device dev = new Device.Device();
            var lista = new List<Device.Device> { dev };
           
            h.Devices = lista;

            h.IsHeaterOn = true;
            h.StartHeatingProcess();

            Assert.AreEqual(true, h.IsHeaterOn); 
        }

        public void ListEmpty()
        {
            Assert.Throws<ArgumentNullException>(
            () =>
            {
                Heater.Heater heater = new Heater.Heater();
                Device.Device dev = new Device.Device();

                heater.IsHeaterOn = false;
                heater.StartHeatingProcess();
                heater.Evidention();

                Assert.AreEqual(false, heater.IsHeaterOn); 
            });
        }

        public void TurnOffHeat()
        {
            Heater.Heater h = new Heater.Heater();
            Device.Device dev = new Device.Device();
            var lista = new List<Device.Device>
            {
                dev
            };

            h.Devices= lista;

            h.IsHeaterOn = false;
            h.StartHeatingProcess();
            h.Evidention();

            Assert.AreEqual(false, h.IsHeaterOn); 
        }

        
    }
}
