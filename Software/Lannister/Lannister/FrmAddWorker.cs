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
    public partial class FrmAddWorker : Form {
        public FrmAddWorker() {
            InitializeComponent();
        }

        private void BtnAddingWorker_Click(object sender, EventArgs e) {
            int Id_Zaposlenika = int.Parse(txtId_Zaposlenika.Text);
            string Korisnicko_ime = txtKorisnicko_ime.Text;
            string Lozinka = txtLozinka.Text;
            string PonovljenaLozinka = txtPonovljenaLozinka.Text;
            string Ime = txtIme.Text;
            string Prezime = txtPrezime.Text;
            string OIB = txtOIB.Text;
            if (Lozinka == PonovljenaLozinka) {
                WorkersRepository.AddWorker(Id_Zaposlenika, Korisnicko_ime, Lozinka, Ime, Prezime, OIB);
                MessageBox.Show("Uspješno ste dodali zaposlenika!", "Uspješno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                new FrmWorkers().ShowDialog();
            } else {
                MessageBox.Show("Lozinke se ne podudaraju!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIzlaz_Click(object sender, EventArgs e) {
            Hide();
            Close();
            new FrmWorkers().ShowDialog();
        }
    }
}
