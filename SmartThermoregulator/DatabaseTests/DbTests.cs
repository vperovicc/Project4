using Database.Implementation;
using Database.Interface;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTests
{
    [TestFixture]
    public  class DbTests
    {

        [Test]
        [TestCase()]
        public void OkayDbConnection()
        {
            Assert.NotNull(DatabaseConnection.GetConnection());
        }

        
        [Test]
        [TestCase(12, "10.1.2024. 11:30", 46.73)]
        [TestCase(12, "10.1.2024. 11:30", 14)]
        [TestCase(12, "10.1.2024. 11:30", 4)]
        [TestCase(12, "10.1.2024. 11:30", 621)]
        [TestCase(12, "10.1.2024. 11:30", 3351)]
        public void DbCorrectMockWrite(int radioSati, string datum, decimal potrosenoKw)
        {
            Mock<IWriteHeaterData> mock = new Mock<IWriteHeaterData>();

            mock.Setup(p => p.EvidencijaRada(radioSati, datum, potrosenoKw)).Returns(true); 
        }


        [TestCase("12", "10.1.2024. 11:30", 46.62)]
        [TestCase(-54, "", 4)]
        [TestCase(-56, "", 22.54)]
        [TestCase(12, "10.1.2024. 11:30", "6")]
        public void DbIncorrectMockWrite(int radioSati, string datum, decimal potrosenoKw)
        {
            Mock<IWriteHeaterData> mock = new Mock<IWriteHeaterData>();

            mock.Setup(p => p.EvidencijaRada(radioSati, datum, potrosenoKw)).Returns(false);
        }

        [Test]
        [TestCase()]
        public void TestForDisposable()
        {
            using (IDbConnection konekcija = DatabaseConnection.GetConnection())
            {
                konekcija.Open();

                konekcija.Dispose();
            }

            var dbase = new DatabaseConnection();
            dbase.Dispose();
            Assert.AreEqual(true, DatabaseConnection.GetInstance());
        }
    }
}
