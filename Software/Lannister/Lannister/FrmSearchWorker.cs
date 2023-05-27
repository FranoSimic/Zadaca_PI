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
    public partial class FrmSearchWorker : Form {
        public FrmSearchWorker() {
            InitializeComponent();  
        }

        private void BtncSearchWorker_Click(object sender, EventArgs e) {
            int id = int.Parse(txtId_ZaposlenikaChange.Text);
            if (WorkersRepository.CheckWorkersId(id)) {
                Worker worker = WorkersRepository.GetWorkerById(id);
                txtId_ZaposlenikaChange.Text = worker.Id.ToString();
                txtKorisnicko_imeChange.Text = worker.Username.ToString();
                txtLozinkaChange.Text = worker.Password.ToString();
                txtImeChange.Text = worker.FirstName.ToString();
                txtPrezimeChange.Text = worker.LastName.ToString();
                txtOIBChange.Text = worker.OIB.ToString();
            } else MessageBox.Show($"Ne postoji zaposlenik koji ima ID={id}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

        }

        private void button1_Click(object sender, EventArgs e) {
            Hide();
            Close();
        }

    }
}
