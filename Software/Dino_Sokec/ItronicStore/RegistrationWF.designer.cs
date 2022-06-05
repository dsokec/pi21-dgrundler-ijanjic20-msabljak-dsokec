
namespace Projekt2022
{
    partial class RegistrationWF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnosKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtUnosLozinka = new System.Windows.Forms.TextBox();
            this.txtUnosPotvrdaLozinke = new System.Windows.Forms.TextBox();
            this.btnRegistrirajSe = new System.Windows.Forms.Button();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unesi lozinku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Potvrdi lozinku";
            // 
            // txtUnosKorisnickoIme
            // 
            this.txtUnosKorisnickoIme.Location = new System.Drawing.Point(184, 69);
            this.txtUnosKorisnickoIme.Name = "txtUnosKorisnickoIme";
            this.txtUnosKorisnickoIme.Size = new System.Drawing.Size(208, 26);
            this.txtUnosKorisnickoIme.TabIndex = 1;
            // 
            // txtUnosLozinka
            // 
            this.txtUnosLozinka.Location = new System.Drawing.Point(184, 119);
            this.txtUnosLozinka.Name = "txtUnosLozinka";
            this.txtUnosLozinka.Size = new System.Drawing.Size(208, 26);
            this.txtUnosLozinka.TabIndex = 2;
            // 
            // txtUnosPotvrdaLozinke
            // 
            this.txtUnosPotvrdaLozinke.Location = new System.Drawing.Point(184, 172);
            this.txtUnosPotvrdaLozinke.Name = "txtUnosPotvrdaLozinke";
            this.txtUnosPotvrdaLozinke.Size = new System.Drawing.Size(208, 26);
            this.txtUnosPotvrdaLozinke.TabIndex = 3;
            // 
            // btnRegistrirajSe
            // 
            this.btnRegistrirajSe.Location = new System.Drawing.Point(79, 233);
            this.btnRegistrirajSe.Name = "btnRegistrirajSe";
            this.btnRegistrirajSe.Size = new System.Drawing.Size(122, 44);
            this.btnRegistrirajSe.TabIndex = 4;
            this.btnRegistrirajSe.Text = "Registriraj se";
            this.btnRegistrirajSe.UseVisualStyleBackColor = true;
            this.btnRegistrirajSe.Click += new System.EventHandler(this.btnRegistrirajSe_Click);
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(270, 233);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(122, 44);
            this.btnPrijaviSe.TabIndex = 5;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(184, 306);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 43);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // RegistrationWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 373);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.btnRegistrirajSe);
            this.Controls.Add(this.txtUnosPotvrdaLozinke);
            this.Controls.Add(this.txtUnosLozinka);
            this.Controls.Add(this.txtUnosKorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.RegistrationWF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnosKorisnickoIme;
        private System.Windows.Forms.TextBox txtUnosLozinka;
        private System.Windows.Forms.TextBox txtUnosPotvrdaLozinke;
        private System.Windows.Forms.Button btnRegistrirajSe;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Button btnOdustani;
    }
}