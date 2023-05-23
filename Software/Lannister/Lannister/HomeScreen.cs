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
    public partial class HomeScreen : Form {
        public HomeScreen() {
            InitializeComponent();
        }

        private void BtnIzlaz_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnKlijenti_Click(object sender, EventArgs e) {
            List<Worker> workers = WorkersRepository.GetWorkersList();
            int brojac = workers.Count;
            if (brojac == 1) {
                MessageBox.Show("Nema zaposlenih ", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show($"Ima ih  {brojac}", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
