using Heater;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegulatorTests
{
    [TestFixture]
    public class RegTests
    {
        [Test]
        [TestCase()]
        public void ConstructorAllright()
        {
            Regulator regulator = new Regulator();
        }

        [Test]
        [TestCase()]
        public void OkayRegulate()
        {
            Regulator regulator = new Regulator();
            regulator.Regulation();
        }
    }
}
