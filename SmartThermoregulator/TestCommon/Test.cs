using Common.Implementation;
using NUnit.Framework;
using Device;

namespace CommonTests
{
    [TestFixture]
    public class CmnTests
    {
        [Test]
        [TestCase()]
        public void TestEmpty()
        {
            DeviceCollection deviceCollection = new DeviceCollection();

            Assert.AreEqual(0, deviceCollection.GetDevices().Count);
        }

        [Test]
        [TestCase()]
        public void TestGoodDevices()
        {
            DeviceCollection deviceCollection = new DeviceCollection();
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(true, deviceCollection.AddDevice());
            }
        }

        [Test]
        [TestCase()]
        public void TestLimit()
        {
            DeviceCollection deviceCollection = new DeviceCollection();
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(true, deviceCollection.AddDevice());
            }

            Assert.AreEqual(false, deviceCollection.AddDevice());
        }
    }
}
