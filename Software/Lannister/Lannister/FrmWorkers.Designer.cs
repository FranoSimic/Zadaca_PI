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
            this.BtnChangeWorker = new System.Windows.Forms.Button();
            this.BtnBackToHomeScreen = new System.Windows.Forms.Button();
            this.BtnAddWorker = new System.Windows.Forms.Button();
            this.BtnDeleteWorker = new System.Windows.Forms.Button();
            this.btnCearchWorker = new System.Windows.Forms.Button();
            this.textSearchWorker2 = new System.Windows.Forms.TextBox();
            this.btnSearchWorker2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcWorkers
            // 
            this.dgcWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcWorkers.Location = new System.Drawing.Point(16, 83);
            this.dgcWorkers.Margin = new System.Windows.Forms.Padding(5);
            this.dgcWorkers.Name = "dgcWorkers";
            this.dgcWorkers.RowHeadersWidth = 100;
            this.dgcWorkers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgcWorkers.Size = new System.Drawing.Size(985, 459);
            this.dgcWorkers.TabIndex = 5;
            // 
            // BtnChangeWorker
            // 
            this.BtnChangeWorker.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnChangeWorker.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Bold);
            this.BtnChangeWorker.Location = new System.Drawing.Point(416, 550);
            this.BtnChangeWorker.Name = "BtnChangeWorker";
            this.BtnChangeWorker.Size = new System.Drawing.Size(194, 52);
            this.BtnChangeWorker.TabIndex = 9;
            this.BtnChangeWorker.Text = "Izmjeni zaposlenika";
            this.BtnChangeWorker.UseVisualStyleBackColor = false;
            this.BtnChangeWorker.Click += new System.EventHandler(this.BtnChangeWorker_Click);
            // 
            // BtnBackToHomeScreen
            // 
            this.BtnBackToHomeScreen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBackToHomeScreen.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Bold);
            this.BtnBackToHomeScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBackToHomeScreen.Location = new System.Drawing.Point(836, 550);
            this.BtnBackToHomeScreen.Name = "BtnBackToHomeScreen";
            this.BtnBackToHomeScreen.Size = new System.Drawing.Size(165, 52);
            this.BtnBackToHomeScreen.TabIndex = 8;
            this.BtnBackToHomeScreen.Text = "Početni zaslon";
            this.BtnBackToHomeScreen.UseVisualStyleBackColor = false;
            this.BtnBackToHomeScreen.Click += new System.EventHandler(this.BtnBackToHomeScreen_Click);
            // 
            // BtnAddWorker
            // 
            this.BtnAddWorker.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAddWorker.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Bold);
            this.BtnAddWorker.Location = new System.Drawing.Point(16, 550);
            this.BtnAddWorker.Name = "BtnAddWorker";
            this.BtnAddWorker.Size = new System.Drawing.Size(194, 52);
            this.BtnAddWorker.TabIndex = 7;
            this.BtnAddWorker.Text = "Dodaj zaposlenika";
            this.BtnAddWorker.UseVisualStyleBackColor = false;
            this.BtnAddWorker.Click += new System.EventHandler(this.BtnAddWorker_Click);
            // 
            // BtnDeleteWorker
            // 
            this.BtnDeleteWorker.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnDeleteWorker.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDeleteWorker.Location = new System.Drawing.Point(216, 550);
            this.BtnDeleteWorker.Name = "BtnDeleteWorker";
            this.BtnDeleteWorker.Size = new System.Drawing.Size(194, 52);
            this.BtnDeleteWorker.TabIndex = 6;
            this.BtnDeleteWorker.Text = "Obriši zaposlenika";
            this.BtnDeleteWorker.UseVisualStyleBackColor = false;
            this.BtnDeleteWorker.Click += new System.EventHandler(this.BtnDeleteWorker_Click);
            // 
            // btnCearchWorker
            // 
            this.btnCearchWorker.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCearchWorker.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Bold);
            this.btnCearchWorker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCearchWorker.Location = new System.Drawing.Point(616, 550);
            this.btnCearchWorker.Name = "btnCearchWorker";
            this.btnCearchWorker.Size = new System.Drawing.Size(214, 52);
            this.btnCearchWorker.TabIndex = 10;
            this.btnCearchWorker.Text = "Pretraži zaposlenika";
            this.btnCearchWorker.UseVisualStyleBackColor = false;
            this.btnCearchWorker.Click += new System.EventHandler(this.btnCearchWorker_Click);
            // 
            // textSearchWorker2
            // 
            this.textSearchWorker2.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Bold);
            this.textSearchWorker2.Location = new System.Drawing.Point(21, 33);
            this.textSearchWorker2.Name = "textSearchWorker2";
            this.textSearchWorker2.Size = new System.Drawing.Size(276, 30);
            this.textSearchWorker2.TabIndex = 11;
            // 
            // btnSearchWorker2
            // 
            this.btnSearchWorker2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearchWorker2.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearchWorker2.Location = new System.Drawing.Point(303, 33);
            this.btnSearchWorker2.Name = "btnSearchWorker2";
            this.btnSearchWorker2.Size = new System.Drawing.Size(209, 30);
            this.btnSearchWorker2.TabIndex = 12;
            this.btnSearchWorker2.Text = "Pretraži zaposlenika";
            this.btnSearchWorker2.UseVisualStyleBackColor = false;
            this.btnSearchWorker2.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 611);
            this.Controls.Add(this.btnSearchWorker2);
            this.Controls.Add(this.textSearchWorker2);
            this.Controls.Add(this.btnCearchWorker);
            this.Controls.Add(this.BtnChangeWorker);
            this.Controls.Add(this.BtnBackToHomeScreen);
            this.Controls.Add(this.BtnAddWorker);
            this.Controls.Add(this.BtnDeleteWorker);
            this.Controls.Add(this.dgcWorkers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWorkers";
            this.Load += new System.EventHandler(this.FrmWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgcWorkers;
        private System.Windows.Forms.Button BtnChangeWorker;
        private System.Windows.Forms.Button BtnBackToHomeScreen;
        private System.Windows.Forms.Button BtnAddWorker;
        private System.Windows.Forms.Button BtnDeleteWorker;
        private System.Windows.Forms.Button btnCearchWorker;
        private System.Windows.Forms.TextBox textSearchWorker2;
        private System.Windows.Forms.Button btnSearchWorker2;
    }
}