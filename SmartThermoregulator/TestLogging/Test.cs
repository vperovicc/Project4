using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging;
using NUnit.Framework;

namespace LoggerTests
{
    [TestFixture]
    public class LogTests
    {
        [Test]
        [TestCase(null)]
        public void TestNull(string name)
        {
            Assert.Throws<ArgumentNullException>(
            () =>
            {
                Log log = new Log(name);
            });
        }

        [Test]
        [TestCase("")]
        public void TestEmpty(string name)
        {
            Assert.Throws<ArgumentException>(
            () =>
            {
                Log log = new Log(name);
            });
        }

        [Test]
        [TestCase("message")]
        public void TestMessage(string name)
        {
            Log log = new Log(name);

            Assert.AreEqual(name, log.Message);
        }

        [Test]
        [TestCase("")]
        public void TestEmpty1(string name)
        {
            new LogFile(name);
        }

        // logporuka
        [Test]
        [TestCase(null)]
        public void TestLogNull(string name)
        {
            Assert.Throws<ArgumentNullException>(
            () =>
            {
                Log log = new Log(name);
            });
        }

        [Test]
        [TestCase("")]
        public void TestLogEmpty(string name)
        {
            Assert.Throws<ArgumentException>(
            () =>
            {
                Log log = new Log(name);
            });
        }

        [Test]
        [TestCase("message")]
        public void TestLogMessage(string name)
        {
            Log log = new Log(name);

            Assert.AreEqual(name, log.Message);
        }
    }
}
