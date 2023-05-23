using Lannister.Models;
using Lannister.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lannister {
    public partial class FrmLogin : Form {

        public static Worker LoggedWorker { get; set; }
        public FrmLogin() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            Console.WriteLine("U konzoli sam");
            int usernamePasswordCheck = 0;
            if (txtUsername.Text != "") usernamePasswordCheck += 2;
            if (txtPassword.Text != "") usernamePasswordCheck++;

            
        }

        private void LoginButton_Click_1(object sender, EventArgs e) {
            Console.WriteLine("U konzoli sam");
            int usernamePasswordCheck = 0;
            if (txtUsername.Text != "") usernamePasswordCheck += 2;
            if (txtPassword.Text != "") usernamePasswordCheck++;

            // Provjerava je li sve uneseno
            switch (usernamePasswordCheck) {
                case 0: {
                        MessageBox.Show("Korisničko ime i lozinka nisu uneseni!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 1: {
                        MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 2: {
                        MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 3: {

                        LoggedWorker = WorkersRepository.GetWorkerByUsername(txtUsername.Text);
                        if (LoggedWorker != null && LoggedWorker.CheckPassword(txtPassword.Text)) {

                            HomeScreen frmHomeScreen = new HomeScreen();
                            Hide();
                            frmHomeScreen.ShowDialog();
                            Close();
                        } else {
                            MessageBox.Show("Neispravni podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }
    }
}
