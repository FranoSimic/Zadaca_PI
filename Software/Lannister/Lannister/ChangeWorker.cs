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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Lannister {
    public partial class ChangeWorker : Form {

        public ChangeWorker(int id) {
            InitializeComponent();
            Worker worker = WorkersRepository.GetWorkerById(id);
            txtId_ZaposlenikaChange.Text = worker.Id.ToString();
            txtKorisnicko_imeChange.Text = worker.Username.ToString();
            txtLozinkaChange.Text = worker.Password.ToString();
            txtPonovljenaLozinkaChange.Text = worker.Password.ToString();
            txtImeChange.Text = worker.FirstName.ToString();
            txtPrezimeChange.Text = worker.LastName.ToString();
            txtOIBChange.Text = worker.OIB.ToString();
        }

        private void BtnChangeWorker_Click(object sender, EventArgs e) {
            int Id_Zaposlenika = int.Parse(txtId_ZaposlenikaChange.Text);
            string Korisnicko_ime = txtKorisnicko_imeChange.Text;
            string Lozinka = txtLozinkaChange.Text;
            string PonovljenaLozinka = txtPonovljenaLozinkaChange.Text;
            string Ime = txtImeChange.Text;
            string Prezime = txtPrezimeChange.Text;
            string OIB = txtOIBChange.Text;
            WorkersRepository.UpdateWorker(Id_Zaposlenika, Korisnicko_ime, Lozinka, Ime, Prezime, OIB);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e) {
            Hide();
            Close();
        }
    }
}
