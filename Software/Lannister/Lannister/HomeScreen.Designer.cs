namespace Lannister {
    partial class HomeScreen {
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
            this.BtnIzlaz = new System.Windows.Forms.Button();
            this.BtnKreirajRaspored = new System.Windows.Forms.Button();
            this.BtnKlijenti = new System.Windows.Forms.Button();
            this.BtnZaposlenici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIzlaz
            // 
            this.BtnIzlaz.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnIzlaz.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Bold);
            this.BtnIzlaz.Location = new System.Drawing.Point(315, 213);
            this.BtnIzlaz.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIzlaz.Name = "BtnIzlaz";
            this.BtnIzlaz.Size = new System.Drawing.Size(261, 170);
            this.BtnIzlaz.TabIndex = 7;
            this.BtnIzlaz.Text = "IZLAZ";
            this.BtnIzlaz.UseVisualStyleBackColor = false;
            this.BtnIzlaz.Click += new System.EventHandler(this.BtnIzlaz_Click);
            // 
            // BtnKreirajRaspored
            // 
            this.BtnKreirajRaspored.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnKreirajRaspored.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Bold);
            this.BtnKreirajRaspored.Location = new System.Drawing.Point(49, 213);
            this.BtnKreirajRaspored.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKreirajRaspored.Name = "BtnKreirajRaspored";
            this.BtnKreirajRaspored.Size = new System.Drawing.Size(261, 171);
            this.BtnKreirajRaspored.TabIndex = 6;
            this.BtnKreirajRaspored.Text = "KREIRAJ RASPORED";
            this.BtnKreirajRaspored.UseVisualStyleBackColor = false;
            // 
            // BtnKlijenti
            // 
            this.BtnKlijenti.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnKlijenti.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Bold);
            this.BtnKlijenti.Location = new System.Drawing.Point(315, 38);
            this.BtnKlijenti.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKlijenti.Name = "BtnKlijenti";
            this.BtnKlijenti.Size = new System.Drawing.Size(262, 171);
            this.BtnKlijenti.TabIndex = 5;
            this.BtnKlijenti.Text = "BROJ ZAPOSLENIH";
            this.BtnKlijenti.UseVisualStyleBackColor = false;
            // 
            // BtnZaposlenici
            // 
            this.BtnZaposlenici.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnZaposlenici.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Bold);
            this.BtnZaposlenici.Location = new System.Drawing.Point(49, 38);
            this.BtnZaposlenici.Margin = new System.Windows.Forms.Padding(2);
            this.BtnZaposlenici.Name = "BtnZaposlenici";
            this.BtnZaposlenici.Size = new System.Drawing.Size(262, 171);
            this.BtnZaposlenici.TabIndex = 4;
            this.BtnZaposlenici.Text = "ZAPOSLENICI";
            this.BtnZaposlenici.UseVisualStyleBackColor = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(634, 431);
            this.Controls.Add(this.BtnIzlaz);
            this.Controls.Add(this.BtnKreirajRaspored);
            this.Controls.Add(this.BtnKlijenti);
            this.Controls.Add(this.BtnZaposlenici);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIzlaz;
        private System.Windows.Forms.Button BtnKreirajRaspored;
        private System.Windows.Forms.Button BtnKlijenti;
        private System.Windows.Forms.Button BtnZaposlenici;
    }
}