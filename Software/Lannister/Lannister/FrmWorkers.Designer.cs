namespace Lannister {
    partial class FrmWorkers {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgcWorkers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgcWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcWorkers
            // 
            this.dgcWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcWorkers.Location = new System.Drawing.Point(16, 16);
            this.dgcWorkers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgcWorkers.Name = "dgcWorkers";
            this.dgcWorkers.RowHeadersWidth = 51;
            this.dgcWorkers.Size = new System.Drawing.Size(978, 526);
            this.dgcWorkers.TabIndex = 5;
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 563);
            this.Controls.Add(this.dgcWorkers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWorkers";
            this.Load += new System.EventHandler(this.FrmWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgcWorkers;
    }
}