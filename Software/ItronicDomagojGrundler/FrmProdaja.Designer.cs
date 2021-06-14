
namespace Itronic
{
    partial class FrmProdaja
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
            this.dgvNarudzba = new System.Windows.Forms.DataGridView();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.lblUkupnaCijenaIznos = new System.Windows.Forms.Label();
            this.btnMakniFiltriranje = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.msHelp = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItronicManual = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).BeginInit();
            this.msHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(23, 90);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(603, 210);
            this.dgvProizvodi.TabIndex = 0;
            // 
            // dgvNarudzba
            // 
            this.dgvNarudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzba.Location = new System.Drawing.Point(23, 366);
            this.dgvNarudzba.Name = "dgvNarudzba";
            this.dgvNarudzba.RowHeadersWidth = 51;
            this.dgvNarudzba.RowTemplate.Height = 24;
            this.dgvNarudzba.Size = new System.Drawing.Size(603, 210);
            this.dgvNarudzba.TabIndex = 1;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(104, 317);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtKolicina.TabIndex = 2;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKolicina.Location = new System.Drawing.Point(25, 317);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(73, 18);
            this.lblKolicina.TabIndex = 3;
            this.lblKolicina.Text = "Količina:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(227, 312);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(65, 33);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(525, 582);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(100, 44);
            this.btnNaruci.TabIndex = 5;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKategorija.Location = new System.Drawing.Point(24, 64);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(89, 18);
            this.lblKategorija.TabIndex = 6;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(119, 58);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cbKategorija.TabIndex = 7;
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaCijena.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(24, 594);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(144, 18);
            this.lblUkupnaCijena.TabIndex = 8;
            this.lblUkupnaCijena.Text = "UKUPNA CIJENA:";
            // 
            // lblUkupnaCijenaIznos
            // 
            this.lblUkupnaCijenaIznos.AutoSize = true;
            this.lblUkupnaCijenaIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaCijenaIznos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUkupnaCijenaIznos.Location = new System.Drawing.Point(213, 594);
            this.lblUkupnaCijenaIznos.Name = "lblUkupnaCijenaIznos";
            this.lblUkupnaCijenaIznos.Size = new System.Drawing.Size(17, 18);
            this.lblUkupnaCijenaIznos.TabIndex = 9;
            this.lblUkupnaCijenaIznos.Text = "0";
            // 
            // btnMakniFiltriranje
            // 
            this.btnMakniFiltriranje.Location = new System.Drawing.Point(371, 55);
            this.btnMakniFiltriranje.Name = "btnMakniFiltriranje";
            this.btnMakniFiltriranje.Size = new System.Drawing.Size(119, 29);
            this.btnMakniFiltriranje.TabIndex = 10;
            this.btnMakniFiltriranje.Text = "Makni filtriranje";
            this.btnMakniFiltriranje.UseVisualStyleBackColor = true;
            this.btnMakniFiltriranje.Click += new System.EventHandler(this.btnMakniFiltriranje_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(246, 55);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(119, 29);
            this.btnFiltriraj.TabIndex = 11;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(419, 582);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // msHelp
            // 
            this.msHelp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp});
            this.msHelp.Location = new System.Drawing.Point(0, 0);
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(642, 28);
            this.msHelp.TabIndex = 13;
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
            // FrmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(642, 630);
            this.Controls.Add(this.msHelp);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnMakniFiltriranje);
            this.Controls.Add(this.lblUkupnaCijenaIznos);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.dgvNarudzba);
            this.Controls.Add(this.dgvProizvodi);
            this.Name = "FrmProdaja";
            this.Text = "Prodaja";
            this.Load += new System.EventHandler(this.FrmProdaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).EndInit();
            this.msHelp.ResumeLayout(false);
            this.msHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.DataGridView dgvNarudzba;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.Label lblUkupnaCijenaIznos;
        private System.Windows.Forms.Button btnMakniFiltriranje;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.MenuStrip msHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiItronicManual;
    }
}