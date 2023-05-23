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
    public partial class FrmWorkers : Form {
        public FrmWorkers() {
            InitializeComponent();
        }

        private void FrmWorkers_Load(object sender, EventArgs e) {
            ShowWorkers();
        }
        private void ShowWorkers() {
            List<Worker> workers = WorkersRepository.GetWorkersList();
            dgcWorkers.DataSource = workers;

            dgcWorkers.Columns["Id"].DisplayIndex = 0;
            dgcWorkers.Columns["FirstName"].DisplayIndex = 1;
            dgcWorkers.Columns["LastName"].DisplayIndex = 2;
            dgcWorkers.Columns["Username"].DisplayIndex = 3;
            dgcWorkers.Columns["Password"].DisplayIndex = 4;
            dgcWorkers.Columns["OIB"].DisplayIndex = 5;
            dgcWorkers.Columns["OIB"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgcWorkers.Columns["OIB"].Width = 200;
        }
        public Worker SelectedWorker() {
            return dgcWorkers.CurrentRow.DataBoundItem as Worker;
        }
        private void BtnBackToHomeScreen_Click(object sender, EventArgs e) {
            Hide();
            Close();
            new HomeScreen().ShowDialog();
        }

        private void BtnAddWorker_Click(object sender, EventArgs e) {
            Hide();
            Close();
            new FrmAddWorker().ShowDialog();
        }

        private void BtnDeleteWorker_Click(object sender, EventArgs e) {
            new FrmDeleteWorkerConfirm().ShowDialog();
            if (FrmDeleteWorkerConfirm.workerDeleted) {
                int id = SelectedWorker().Id;
                WorkersRepository.DeleteWorker(id);
                MessageBox.Show("Uspješno ste obrisali zaposlenika!", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Close();
                new FrmWorkers().ShowDialog();
            } else {
                MessageBox.Show("Nije obrisan zaposlenik!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChangeWorker_Click(object sender, EventArgs e) {
            Hide();
            Close();
            new ChangeWorker(SelectedWorker().Id).ShowDialog();
        }

        private void btnCearchWorker_Click(object sender, EventArgs e) {
            Hide();
            Close();
            new FrmSearchWorker().ShowDialog();
        }
    }
}
