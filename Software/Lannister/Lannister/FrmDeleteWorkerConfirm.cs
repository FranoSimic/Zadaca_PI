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
    public partial class FrmDeleteWorkerConfirm : Form {
        public FrmDeleteWorkerConfirm() {
            InitializeComponent();
        }
        public static bool workerDeleted = false;
        private void button1_Click(object sender, EventArgs e) {
            workerDeleted = true;
            Hide();
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            workerDeleted = false;
            Hide();
            Close();
        }
    }
}
