using Database.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Implementation
{
    public class WriteHeaterData : IWriteHeaterData
    {
        public bool EvidencijaRada(int radniSati, string datum, decimal potrosnjaKw)
        {
            using (IDbConnection konekcija = DatabaseConnection.GetConnection())
            {
                konekcija.Open();

                using (IDbCommand komanda = konekcija.CreateCommand())
                {
                    komanda.CommandText = "INSERT INTO HEATER VALUES(" + radniSati + ", '" + datum + "'," + potrosnjaKw + ")";
                    komanda.Prepare();

                    return komanda.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
