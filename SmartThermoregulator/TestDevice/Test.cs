using NUnit.Framework;
using Device;

namespace DeviceTests
{
    [TestFixture]
    public class DevTests
    {
        [Test]
        [TestCase()]
        public void TestTickDevice()
        {
            Device.Device device1 = new Device.Device();
            Device.Device device2 = new Device.Device();

            Assert.AreEqual(device1.DeviceID, device2.DeviceID);
            Assert.AreEqual(device1.Temperature, device2.Temperature);
        }

        [Test]
        [TestCase()]
        public void TestTickDeviceDelayed()
        {
            Device.Device device1 = new Device.Device();
            System.Threading.Thread.Sleep(20);
            System.Threading.Thread.Sleep(4);
            System.Threading.Thread.Sleep(4);
            Device.Device device2 = new Device.Device();

            Assert.AreEqual(device1.DeviceID, device2.DeviceID);
            Assert.AreEqual(device1.Temperature, device2.Temperature);
        }

        [Test]
        [TestCase(3)]
        [TestCase(2)]
        [TestCase(-6.9)]
        [TestCase(4.2)]
        [TestCase(12)]
        public void TestChangableOC(double n_temp)
        {
            Device.Device device = new Device.Device();

            device.Temperature = n_temp;

            Assert.AreEqual(n_temp, device.Temperature);
        }
    }
}
