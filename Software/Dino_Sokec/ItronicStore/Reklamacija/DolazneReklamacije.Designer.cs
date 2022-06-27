
namespace ItronicStore
{
    partial class DolazneReklamacije
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
            this.dgvPopisReklamacija = new System.Windows.Forms.DataGridView();
            this.cmbFiltar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblPrijavljenKao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvPovijestReklamacija = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtProizvod = new System.Windows.Forms.TextBox();
            this.txtPrigovor = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisReklamacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestReklamacija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisReklamacija
            // 
            this.dgvPopisReklamacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisReklamacija.Location = new System.Drawing.Point(12, 134);
            this.dgvPopisReklamacija.Name = "dgvPopisReklamacija";
            this.dgvPopisReklamacija.ReadOnly = true;
            this.dgvPopisReklamacija.RowHeadersWidth = 62;
            this.dgvPopisReklamacija.RowTemplate.Height = 28;
            this.dgvPopisReklamacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisReklamacija.Size = new System.Drawing.Size(1113, 261);
            this.dgvPopisReklamacija.TabIndex = 0;
            this.dgvPopisReklamacija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisReklamacija_CellContentClick);
            // 
            // cmbFiltar
            // 
            this.cmbFiltar.FormattingEnabled = true;
            this.cmbFiltar.Items.AddRange(new object[] {
            "Najnovije",
            "Najstarije",
            "Po osobi"});
            this.cmbFiltar.Location = new System.Drawing.Point(196, 18);
            this.cmbFiltar.Name = "cmbFiltar";
            this.cmbFiltar.Size = new System.Drawing.Size(212, 28);
            this.cmbFiltar.TabIndex = 1;
            this.cmbFiltar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtriraj pretragu";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(1050, 844);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 35);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSpremi.Location = new System.Drawing.Point(36, 421);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(86, 35);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // lblPrijavljenKao
            // 
            this.lblPrijavljenKao.AutoSize = true;
            this.lblPrijavljenKao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljenKao.Location = new System.Drawing.Point(818, 18);
            this.lblPrijavljenKao.Name = "lblPrijavljenKao";
            this.lblPrijavljenKao.Size = new System.Drawing.Size(313, 25);
            this.lblPrijavljenKao.TabIndex = 5;
            this.lblPrijavljenKao.Text = "Prijavljen kao: <naziv_admina>";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(18, 792);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ažuriraj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(115, 793);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Obriši";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvPovijestReklamacija
            // 
            this.dgvPovijestReklamacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovijestReklamacija.Location = new System.Drawing.Point(12, 487);
            this.dgvPovijestReklamacija.Name = "dgvPovijestReklamacija";
            this.dgvPovijestReklamacija.RowHeadersWidth = 62;
            this.dgvPovijestReklamacija.RowTemplate.Height = 28;
            this.dgvPovijestReklamacija.Size = new System.Drawing.Size(1118, 267);
            this.dgvPovijestReklamacija.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(143, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Korisnicko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(402, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Proizvod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(737, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prigovor";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.Salmon;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(124, 93);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.ReadOnly = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(152, 26);
            this.txtKorisnickoIme.TabIndex = 12;
            // 
            // txtProizvod
            // 
            this.txtProizvod.ForeColor = System.Drawing.Color.Salmon;
            this.txtProizvod.Location = new System.Drawing.Point(306, 93);
            this.txtProizvod.Multiline = true;
            this.txtProizvod.Name = "txtProizvod";
            this.txtProizvod.ReadOnly = true;
            this.txtProizvod.Size = new System.Drawing.Size(251, 26);
            this.txtProizvod.TabIndex = 12;
            // 
            // txtPrigovor
            // 
            this.txtPrigovor.ForeColor = System.Drawing.Color.Salmon;
            this.txtPrigovor.Location = new System.Drawing.Point(585, 93);
            this.txtPrigovor.Multiline = true;
            this.txtPrigovor.Name = "txtPrigovor";
            this.txtPrigovor.ReadOnly = true;
            this.txtPrigovor.Size = new System.Drawing.Size(403, 26);
            this.txtPrigovor.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(336, 430);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(790, 26);
            this.textBox7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Odgovor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(280, 774);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Korisnicko ime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(539, 774);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Proizvod";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(874, 774);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Prigovor";
            // 
            // textBox8
            // 
            this.textBox8.ForeColor = System.Drawing.Color.Olive;
            this.textBox8.Location = new System.Drawing.Point(261, 797);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(152, 26);
            this.textBox8.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.ForeColor = System.Drawing.Color.Olive;
            this.textBox9.Location = new System.Drawing.Point(443, 797);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(251, 26);
            this.textBox9.TabIndex = 12;
            // 
            // textBox10
            // 
            this.textBox10.ForeColor = System.Drawing.Color.Olive;
            this.textBox10.Location = new System.Drawing.Point(722, 797);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(403, 26);
            this.textBox10.TabIndex = 12;
            // 
            // DolazneReklamacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1143, 891);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txtPrigovor);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProizvod);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPovijestReklamacija);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrijavljenKao);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltar);
            this.Controls.Add(this.dgvPopisReklamacija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DolazneReklamacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DolazneReklamacije";
            this.Load += new System.EventHandler(this.DolazneReklamacije_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DolazneReklamacije_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisReklamacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestReklamacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisReklamacija;
        private System.Windows.Forms.ComboBox cmbFiltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblPrijavljenKao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvPovijestReklamacija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtProizvod;
        private System.Windows.Forms.TextBox txtPrigovor;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}