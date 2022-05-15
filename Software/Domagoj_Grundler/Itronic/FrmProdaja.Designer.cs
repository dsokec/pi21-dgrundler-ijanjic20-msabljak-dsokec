
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnMakniFiltriranje = new System.Windows.Forms.Button();
            this.lblUkupnaCijenaIznos = new System.Windows.Forms.Label();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.dgvKosarica = new System.Windows.Forms.DataGridView();
            this.dgvKatalog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(527, 567);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 25;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(174, 36);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(119, 29);
            this.btnFiltriraj.TabIndex = 24;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnMakniFiltriranje
            // 
            this.btnMakniFiltriranje.Location = new System.Drawing.Point(299, 36);
            this.btnMakniFiltriranje.Name = "btnMakniFiltriranje";
            this.btnMakniFiltriranje.Size = new System.Drawing.Size(119, 29);
            this.btnMakniFiltriranje.TabIndex = 23;
            this.btnMakniFiltriranje.Text = "Makni filtriranje";
            this.btnMakniFiltriranje.UseVisualStyleBackColor = true;
            this.btnMakniFiltriranje.Click += new System.EventHandler(this.btnMakniFiltriranje_Click);
            // 
            // lblUkupnaCijenaIznos
            // 
            this.lblUkupnaCijenaIznos.AutoSize = true;
            this.lblUkupnaCijenaIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaCijenaIznos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUkupnaCijenaIznos.Location = new System.Drawing.Point(562, 302);
            this.lblUkupnaCijenaIznos.Name = "lblUkupnaCijenaIznos";
            this.lblUkupnaCijenaIznos.Size = new System.Drawing.Size(17, 18);
            this.lblUkupnaCijenaIznos.TabIndex = 22;
            this.lblUkupnaCijenaIznos.Text = "0";
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaCijena.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(412, 302);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(144, 18);
            this.lblUkupnaCijena.TabIndex = 21;
            this.lblUkupnaCijena.Text = "UKUPNA CIJENA:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(29, 41);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cbKategorija.TabIndex = 20;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKategorija.Location = new System.Drawing.Point(29, 20);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(89, 18);
            this.lblKategorija.TabIndex = 19;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(415, 567);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(100, 44);
            this.btnNaruci.TabIndex = 18;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(249, 297);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(65, 33);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKolicina.Location = new System.Drawing.Point(26, 306);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(73, 18);
            this.lblKolicina.TabIndex = 16;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(122, 302);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtKolicina.TabIndex = 15;
            // 
            // dgvKosarica
            // 
            this.dgvKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKosarica.Location = new System.Drawing.Point(24, 341);
            this.dgvKosarica.Name = "dgvKosarica";
            this.dgvKosarica.RowHeadersWidth = 51;
            this.dgvKosarica.RowTemplate.Height = 24;
            this.dgvKosarica.Size = new System.Drawing.Size(603, 210);
            this.dgvKosarica.TabIndex = 14;
            // 
            // dgvKatalog
            // 
            this.dgvKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKatalog.Location = new System.Drawing.Point(24, 71);
            this.dgvKatalog.Name = "dgvKatalog";
            this.dgvKatalog.RowHeadersWidth = 51;
            this.dgvKatalog.RowTemplate.Height = 24;
            this.dgvKatalog.Size = new System.Drawing.Size(603, 210);
            this.dgvKatalog.TabIndex = 13;
            this.dgvKatalog.SelectionChanged += new System.EventHandler(this.dgvProizvodi_SelectionChanged);
            // 
            // FrmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(644, 634);
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
            this.Controls.Add(this.dgvKosarica);
            this.Controls.Add(this.dgvKatalog);
            this.Name = "FrmProdaja";
            this.Text = "FrmProdaja";
            this.Load += new System.EventHandler(this.FrmProdaja_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmProdaja_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnMakniFiltriranje;
        private System.Windows.Forms.Label lblUkupnaCijenaIznos;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.DataGridView dgvKosarica;
        private System.Windows.Forms.DataGridView dgvKatalog;
    }
}