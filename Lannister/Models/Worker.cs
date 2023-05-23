using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lannister.Models {
    public class Worker : Person {
        public string Username { get; set; }
        public string Password { get; set; }
        public string OIB { get; set; }

        public bool CheckUsername(string username) {
            return Username == username;
        }
        public bool CheckPassword(string password) {
            return Password == password;
        }
        public bool CheckOIB(string oib) {
            return OIB == oib;
        }
    }
}
