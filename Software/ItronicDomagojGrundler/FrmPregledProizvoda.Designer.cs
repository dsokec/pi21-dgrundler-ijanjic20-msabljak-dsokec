
namespace Itronic
{
    partial class FrmPregledProizvoda
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
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKupovina = new System.Windows.Forms.Button();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnMakniFiltriranje = new System.Windows.Forms.Button();
            this.msHelp = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItronicManual = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.msHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 111);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(776, 338);
            this.dgvProizvodi.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 466);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 55);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj proizvod";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodajAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(234, 466);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 55);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši proizvod";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnKupovina
            // 
            this.btnKupovina.Location = new System.Drawing.Point(582, 466);
            this.btnKupovina.Name = "btnKupovina";
            this.btnKupovina.Size = new System.Drawing.Size(100, 55);
            this.btnKupovina.TabIndex = 4;
            this.btnKupovina.Text = "Izvrši kupovinu";
            this.btnKupovina.UseVisualStyleBackColor = true;
            this.btnKupovina.Click += new System.EventHandler(this.btnKupovina_Click);
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(688, 466);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(100, 55);
            this.btnNaruci.TabIndex = 5;
            this.btnNaruci.Text = "Naruči robu";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(128, 466);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 55);
            this.btnAzuriraj.TabIndex = 6;
            this.btnAzuriraj.Text = "Ažuriraj proizvod";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(12, 71);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cmbKategorija.TabIndex = 7;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(153, 53);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(92, 42);
            this.btnFiltriraj.TabIndex = 8;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnMakniFiltriranje
            // 
            this.btnMakniFiltriranje.Location = new System.Drawing.Point(251, 53);
            this.btnMakniFiltriranje.Name = "btnMakniFiltriranje";
            this.btnMakniFiltriranje.Size = new System.Drawing.Size(92, 42);
            this.btnMakniFiltriranje.TabIndex = 9;
            this.btnMakniFiltriranje.Text = "Makni filtriranje";
            this.btnMakniFiltriranje.UseVisualStyleBackColor = true;
            this.btnMakniFiltriranje.Click += new System.EventHandler(this.btnMakniFiltriranje_Click);
            // 
            // msHelp
            // 
            this.msHelp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp});
            this.msHelp.Location = new System.Drawing.Point(0, 0);
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(800, 28);
            this.msHelp.TabIndex = 10;
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
            this.tsmiItronicManual.Click += new System.EventHandler(this.itronicManualToolStripMenuItem_Click);
            // 
            // FrmPregledProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.btnMakniFiltriranje);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.btnKupovina);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.msHelp);
            this.MainMenuStrip = this.msHelp;
            this.Name = "FrmPregledProizvoda";
            this.Text = "Pregled proizvoda";
            this.Load += new System.EventHandler(this.FrmPregledProizvoda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.msHelp.ResumeLayout(false);
            this.msHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKupovina;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnMakniFiltriranje;
        private System.Windows.Forms.MenuStrip msHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiItronicManual;
    }
}

