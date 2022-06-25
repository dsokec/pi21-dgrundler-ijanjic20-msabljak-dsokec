
namespace ItronicStore
{
    partial class AdminPrijava
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
            this.cmbImeAdmina = new System.Windows.Forms.ComboBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLozinkaAdmin = new System.Windows.Forms.TextBox();
            this.btnPrijaviSeAdmin = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(184, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Admin";
            // 
            // cmbImeAdmina
            // 
            this.cmbImeAdmina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImeAdmina.FormattingEnabled = true;
            this.cmbImeAdmina.Location = new System.Drawing.Point(158, 127);
            this.cmbImeAdmina.Name = "cmbImeAdmina";
            this.cmbImeAdmina.Size = new System.Drawing.Size(165, 28);
            this.cmbImeAdmina.TabIndex = 15;
            this.cmbImeAdmina.SelectedIndexChanged += new System.EventHandler(this.cmbImeAdmina_SelectedIndexChanged);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.ForeColor = System.Drawing.Color.Blue;
            this.lblLozinka.Location = new System.Drawing.Point(67, 176);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(68, 20);
            this.lblLozinka.TabIndex = 11;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNaslov.Location = new System.Drawing.Point(131, 19);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(208, 32);
            this.lblNaslov.TabIndex = 12;
            this.lblNaslov.Text = "Administracija";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.Blue;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(55, 73);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(54, 20);
            this.lblKorisnickoIme.TabIndex = 13;
            this.lblKorisnickoIme.Text = "Admin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLozinkaAdmin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrijaviSeAdmin);
            this.groupBox1.Controls.Add(this.lblKorisnickoIme);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 213);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // txtLozinkaAdmin
            // 
            this.txtLozinkaAdmin.Location = new System.Drawing.Point(146, 115);
            this.txtLozinkaAdmin.Name = "txtLozinkaAdmin";
            this.txtLozinkaAdmin.PasswordChar = '*';
            this.txtLozinkaAdmin.ReadOnly = true;
            this.txtLozinkaAdmin.Size = new System.Drawing.Size(165, 26);
            this.txtLozinkaAdmin.TabIndex = 18;
            // 
            // btnPrijaviSeAdmin
            // 
            this.btnPrijaviSeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSeAdmin.ForeColor = System.Drawing.Color.Blue;
            this.btnPrijaviSeAdmin.Location = new System.Drawing.Point(146, 161);
            this.btnPrijaviSeAdmin.Name = "btnPrijaviSeAdmin";
            this.btnPrijaviSeAdmin.Size = new System.Drawing.Size(165, 32);
            this.btnPrijaviSeAdmin.TabIndex = 2;
            this.btnPrijaviSeAdmin.Text = "Prijavi se";
            this.btnPrijaviSeAdmin.UseVisualStyleBackColor = true;
            this.btnPrijaviSeAdmin.Click += new System.EventHandler(this.btnPrijaviSeAdmin_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNatrag.ForeColor = System.Drawing.Color.Maroon;
            this.btnNatrag.Location = new System.Drawing.Point(390, 273);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 40);
            this.btnNatrag.TabIndex = 17;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // AdminPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 333);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cmbImeAdmina);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPrijava";
            this.Load += new System.EventHandler(this.AdminPrijava_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbImeAdmina;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrijaviSeAdmin;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox txtLozinkaAdmin;
    }
}