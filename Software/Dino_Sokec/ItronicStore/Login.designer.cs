
namespace ItronicStore
{
    partial class wfLogin
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
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbKorisnickoIme = new System.Windows.Forms.ComboBox();
            this.cmbLozinka = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrijavaAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPrijaviSe.Location = new System.Drawing.Point(146, 158);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(165, 32);
            this.btnPrijaviSe.TabIndex = 0;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(346, 142);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(114, 20);
            this.lblKorisnickoIme.TabIndex = 10;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLozinka.Location = new System.Drawing.Point(392, 191);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(68, 20);
            this.lblLozinka.TabIndex = 9;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(478, 37);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(185, 29);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Itronic trgovina";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.Location = new System.Drawing.Point(714, 416);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(66, 40);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 481);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // cmbKorisnickoIme
            // 
            this.cmbKorisnickoIme.FormattingEnabled = true;
            this.cmbKorisnickoIme.Location = new System.Drawing.Point(483, 142);
            this.cmbKorisnickoIme.Name = "cmbKorisnickoIme";
            this.cmbKorisnickoIme.Size = new System.Drawing.Size(165, 28);
            this.cmbKorisnickoIme.TabIndex = 3;
            this.cmbKorisnickoIme.SelectedIndexChanged += new System.EventHandler(this.cmbKorisnickoIme_SelectedIndexChanged);
            // 
            // cmbLozinka
            // 
            this.cmbLozinka.FormattingEnabled = true;
            this.cmbLozinka.Location = new System.Drawing.Point(483, 183);
            this.cmbLozinka.Name = "cmbLozinka";
            this.cmbLozinka.Size = new System.Drawing.Size(165, 28);
            this.cmbLozinka.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrijaviSe);
            this.groupBox1.Location = new System.Drawing.Point(337, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(456, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prijavi se kao korisnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(456, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prijavi se kao admin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrijavaAdmin);
            this.groupBox2.Location = new System.Drawing.Point(447, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 111);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnPrijavaAdmin
            // 
            this.btnPrijavaAdmin.Location = new System.Drawing.Point(36, 61);
            this.btnPrijavaAdmin.Name = "btnPrijavaAdmin";
            this.btnPrijavaAdmin.Size = new System.Drawing.Size(165, 35);
            this.btnPrijavaAdmin.TabIndex = 0;
            this.btnPrijavaAdmin.Text = "Nastavi";
            this.btnPrijavaAdmin.UseVisualStyleBackColor = true;
            this.btnPrijavaAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // wfLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLozinka);
            this.Controls.Add(this.cmbKorisnickoIme);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wfLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.wfLogin_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.wfLogin_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbKorisnickoIme;
        private System.Windows.Forms.ComboBox cmbLozinka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrijavaAdmin;
    }
}

