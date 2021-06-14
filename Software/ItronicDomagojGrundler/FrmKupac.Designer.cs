
namespace Itronic
{
    partial class FrmKupac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnDodajKupca = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBrojMobitela = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBrojMobitela = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.msHelp = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItronicManual = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrezime.Location = new System.Drawing.Point(183, 49);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(75, 18);
            this.lblPrezime.TabIndex = 27;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(186, 69);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(118, 22);
            this.txtPrezime.TabIndex = 26;
            // 
            // btnDodajKupca
            // 
            this.btnDodajKupca.Location = new System.Drawing.Point(277, 206);
            this.btnDodajKupca.Name = "btnDodajKupca";
            this.btnDodajKupca.Size = new System.Drawing.Size(67, 27);
            this.btnDodajKupca.TabIndex = 25;
            this.btnDodajKupca.Text = "OK";
            this.btnDodajKupca.UseVisualStyleBackColor = true;
            this.btnDodajKupca.Click += new System.EventHandler(this.btnDodajKupca_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 22);
            this.txtEmail.TabIndex = 24;
            // 
            // txtBrojMobitela
            // 
            this.txtBrojMobitela.Location = new System.Drawing.Point(15, 123);
            this.txtBrojMobitela.Name = "txtBrojMobitela";
            this.txtBrojMobitela.Size = new System.Drawing.Size(155, 22);
            this.txtBrojMobitela.TabIndex = 23;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(15, 69);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(118, 22);
            this.txtIme.TabIndex = 22;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdresa.Location = new System.Drawing.Point(12, 158);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(129, 18);
            this.lblAdresa.TabIndex = 21;
            this.lblAdresa.Text = "Adresa dostave:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(186, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 18);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // lblBrojMobitela
            // 
            this.lblBrojMobitela.AutoSize = true;
            this.lblBrojMobitela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojMobitela.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBrojMobitela.Location = new System.Drawing.Point(12, 103);
            this.lblBrojMobitela.Name = "lblBrojMobitela";
            this.lblBrojMobitela.Size = new System.Drawing.Size(113, 18);
            this.lblBrojMobitela.TabIndex = 19;
            this.lblBrojMobitela.Text = "Broj mobitela:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIme.Location = new System.Drawing.Point(12, 49);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(40, 18);
            this.lblIme.TabIndex = 18;
            this.lblIme.Text = "Ime:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(15, 178);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(155, 22);
            this.txtAdresa.TabIndex = 28;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(189, 178);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(155, 22);
            this.txtGrad.TabIndex = 30;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGrad.Location = new System.Drawing.Point(186, 158);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(50, 18);
            this.lblGrad.TabIndex = 29;
            this.lblGrad.Text = "Grad:";
            // 
            // msHelp
            // 
            this.msHelp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp});
            this.msHelp.Location = new System.Drawing.Point(0, 0);
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(357, 28);
            this.msHelp.TabIndex = 31;
            this.msHelp.Text = "menuStrip1";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiItronicManual});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(55, 24);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiItronicManual
            // 
            this.tsmiItronicManual.Name = "tsmiItronicManual";
            this.tsmiItronicManual.Size = new System.Drawing.Size(224, 26);
            this.tsmiItronicManual.Text = "ItronicManual";
            this.tsmiItronicManual.Click += new System.EventHandler(this.tsmiItronicManual_Click);
            // 
            // FrmKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(357, 246);
            this.Controls.Add(this.msHelp);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.btnDodajKupca);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBrojMobitela);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBrojMobitela);
            this.Controls.Add(this.lblIme);
            this.Name = "FrmKupac";
            this.Text = "Podaci o kupcu";
            this.Load += new System.EventHandler(this.FrmKupac_Load);
            this.msHelp.ResumeLayout(false);
            this.msHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnDodajKupca;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBrojMobitela;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBrojMobitela;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.MenuStrip msHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiItronicManual;
    }
}