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
            using (IDbConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO HEATER VALUES(" + radniSati + ", '" + datum + "'," + potrosnjaKw + ")";
                    command.Prepare();

                    return command.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
