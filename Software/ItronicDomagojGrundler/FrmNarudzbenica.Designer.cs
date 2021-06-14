
namespace Itronic
{
    partial class FrmNarudzbenica
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
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.lblUkupnaCijenaIznos = new System.Windows.Forms.Label();
            this.dgvNarudzbenica = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnMakniFiltriranje = new System.Windows.Forms.Button();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.msHelp = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItronicManual = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenica)).BeginInit();
            this.msHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(27, 96);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(676, 209);
            this.dgvProizvodi.TabIndex = 0;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKolicina.Location = new System.Drawing.Point(27, 332);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(73, 18);
            this.lblKolicina.TabIndex = 1;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(106, 328);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtKolicina.TabIndex = 2;
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(621, 575);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(82, 33);
            this.btnNaruci.TabIndex = 3;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaCijena.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(34, 579);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(144, 18);
            this.lblUkupnaCijena.TabIndex = 4;
            this.lblUkupnaCijena.Text = "UKUPNA CIJENA:";
            // 
            // lblUkupnaCijenaIznos
            // 
            this.lblUkupnaCijenaIznos.AutoSize = true;
            this.lblUkupnaCijenaIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaCijenaIznos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUkupnaCijenaIznos.Location = new System.Drawing.Point(210, 579);
            this.lblUkupnaCijenaIznos.Name = "lblUkupnaCijenaIznos";
            this.lblUkupnaCijenaIznos.Size = new System.Drawing.Size(17, 18);
            this.lblUkupnaCijenaIznos.TabIndex = 5;
            this.lblUkupnaCijenaIznos.Text = "0";
            // 
            // dgvNarudzbenica
            // 
            this.dgvNarudzbenica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenica.Location = new System.Drawing.Point(27, 367);
            this.dgvNarudzbenica.Name = "dgvNarudzbenica";
            this.dgvNarudzbenica.RowHeadersWidth = 51;
            this.dgvNarudzbenica.RowTemplate.Height = 24;
            this.dgvNarudzbenica.Size = new System.Drawing.Size(676, 198);
            this.dgvNarudzbenica.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(233, 327);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(533, 576);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(82, 32);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(259, 60);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(119, 29);
            this.btnFiltriraj.TabIndex = 15;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnMakniFiltriranje
            // 
            this.btnMakniFiltriranje.Location = new System.Drawing.Point(384, 60);
            this.btnMakniFiltriranje.Name = "btnMakniFiltriranje";
            this.btnMakniFiltriranje.Size = new System.Drawing.Size(119, 29);
            this.btnMakniFiltriranje.TabIndex = 14;
            this.btnMakniFiltriranje.Text = "Makni filtriranje";
            this.btnMakniFiltriranje.UseVisualStyleBackColor = true;
            this.btnMakniFiltriranje.Click += new System.EventHandler(this.btnMakniFiltriranje_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(132, 63);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cbKategorija.TabIndex = 13;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKategorija.Location = new System.Drawing.Point(34, 69);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(89, 18);
            this.lblKategorija.TabIndex = 12;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // msHelp
            // 
            this.msHelp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp});
            this.msHelp.Location = new System.Drawing.Point(0, 0);
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(720, 28);
            this.msHelp.TabIndex = 16;
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
            // FrmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(720, 618);
            this.Controls.Add(this.msHelp);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnMakniFiltriranje);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvNarudzbenica);
            this.Controls.Add(this.lblUkupnaCijenaIznos);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.dgvProizvodi);
            this.Name = "FrmNarudzbenica";
            this.Text = "Narudžbenica";
            this.Load += new System.EventHandler(this.FrmNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenica)).EndInit();
            this.msHelp.ResumeLayout(false);
            this.msHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.Label lblUkupnaCijenaIznos;
        private System.Windows.Forms.DataGridView dgvNarudzbenica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnMakniFiltriranje;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.MenuStrip msHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiItronicManual;
    }
}