using DBLayer;
using Lannister.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lannister.Repositories {
    internal class WorkersRepository {
        public static Worker GetWorkerByUsername(string username) {
            string sql = $"SELECT * FROM LannisterTable WHERE Korisnicko_Ime = '{username}'";
            return FetchWorker(sql);
        }
        private static Worker FetchWorker(string sql) {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Worker worker = null;
            if (reader.HasRows) {
                reader.Read();
                worker = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return worker;
        }

        public static Worker CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id_Zaposlenika"].ToString());
            string username = reader["Korisnicko_ime"].ToString();
            string password = reader["Lozinka"].ToString();
            string firstName = reader["Ime"].ToString();
            string lastName = reader["Prezime"].ToString();
            string oib = reader["OIB"].ToString();

            var worker = new Worker {
                Id = id,
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                OIB = oib
            };
            return worker;
        }
    }
}
