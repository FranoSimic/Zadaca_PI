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
        public static Worker GetWorkerById(int id) {
            string sql = $"SELECT * FROM LannisterTable WHERE Id_Zaposlenika = '{id}'";
            return FetchWorker(sql);
        }
        public static void DeleteWorker(int id) {
            string sql = $"DELETE FROM LannisterTable Where ID_Zaposlenika = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void AddWorker(int id, string Korisnicko_Ime, string Lozinka, string Ime, string Prezime, string OIB) {
            string sql = $"INSERT INTO LannisterTable (Id_Zaposlenika, Korisnicko_ime, Lozinka, Ime, prezime, OIB) VALUES ('{id}', '{Korisnicko_Ime}', '{Lozinka}', '{Ime}', '{Prezime}', '{OIB}');";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
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

        public static List<Worker> GetWorkersList() {
            List<Worker> workers = new List<Worker>();
            string sql = "SELECT * FROM LannisterTable";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Worker worker = CreateObject(reader);
                workers.Add(worker);
            }
            reader.Close();
            DB.CloseConnection();
            return workers; 
        }
    }
}
