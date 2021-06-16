
namespace Itronic
{
    partial class FrmPrimka
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
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnMakniFiltriranje = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPrimka = new System.Windows.Forms.DataGridView();
            this.lblUkupnaCijenaIznos = new System.Windows.Forms.Label();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.dgvKatalog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(244, 13);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(119, 29);
            this.btnFiltriraj.TabIndex = 28;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnMakniFiltriranje
            // 
            this.btnMakniFiltriranje.Location = new System.Drawing.Point(369, 13);
            this.btnMakniFiltriranje.Name = "btnMakniFiltriranje";
            this.btnMakniFiltriranje.Size = new System.Drawing.Size(119, 29);
            this.btnMakniFiltriranje.TabIndex = 27;
            this.btnMakniFiltriranje.Text = "Makni filtriranje";
            this.btnMakniFiltriranje.UseVisualStyleBackColor = true;
            this.btnMakniFiltriranje.Click += new System.EventHandler(this.btnMakniFiltriranje_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(117, 16);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cmbKategorija.TabIndex = 26;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKategorija.Location = new System.Drawing.Point(19, 22);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(89, 18);
            this.lblKategorija.TabIndex = 25;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(518, 529);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(82, 32);
            this.btnOdustani.TabIndex = 24;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(218, 280);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPrimka
            // 
            this.dgvPrimka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimka.Location = new System.Drawing.Point(12, 320);
            this.dgvPrimka.Name = "dgvPrimka";
            this.dgvPrimka.RowHeadersWidth = 51;
            this.dgvPrimka.RowTemplate.Height = 24;
            this.dgvPrimka.Size = new System.Drawing.Size(676, 198);
            this.dgvPrimka.TabIndex = 22;
            // 
            // lblUkupnaCijenaIznos
            // 
            this.lblUkupnaCijenaIznos.AutoSize = true;
            this.lblUkupnaCijenaIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaCijenaIznos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUkupnaCijenaIznos.Location = new System.Drawing.Point(195, 532);
            this.lblUkupnaCijenaIznos.Name = "lblUkupnaCijenaIznos";
            this.lblUkupnaCijenaIznos.Size = new System.Drawing.Size(17, 18);
            this.lblUkupnaCijenaIznos.TabIndex = 21;
            this.lblUkupnaCijenaIznos.Text = "0";
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaCijena.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(19, 532);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(144, 18);
            this.lblUkupnaCijena.TabIndex = 20;
            this.lblUkupnaCijena.Text = "UKUPNA CIJENA:";
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(606, 528);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(82, 33);
            this.btnNaruci.TabIndex = 19;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(91, 281);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtKolicina.TabIndex = 18;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKolicina.Location = new System.Drawing.Point(12, 285);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(73, 18);
            this.lblKolicina.TabIndex = 17;
            this.lblKolicina.Text = "Količina:";
            // 
            // dgvKatalog
            // 
            this.dgvKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKatalog.Location = new System.Drawing.Point(12, 49);
            this.dgvKatalog.Name = "dgvKatalog";
            this.dgvKatalog.RowHeadersWidth = 51;
            this.dgvKatalog.RowTemplate.Height = 24;
            this.dgvKatalog.Size = new System.Drawing.Size(676, 209);
            this.dgvKatalog.TabIndex = 16;
            this.dgvKatalog.SelectionChanged += new System.EventHandler(this.dgvKatalog_SelectionChanged);
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(712, 578);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnMakniFiltriranje);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPrimka);
            this.Controls.Add(this.lblUkupnaCijenaIznos);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.dgvKatalog);
            this.Name = "FrmPrimka";
            this.Text = "Naručivanje zaliha";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnMakniFiltriranje;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPrimka;
        private System.Windows.Forms.Label lblUkupnaCijenaIznos;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.DataGridView dgvKatalog;
    }
}