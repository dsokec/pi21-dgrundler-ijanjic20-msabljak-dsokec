
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
            this.dgvKatalog = new System.Windows.Forms.DataGridView();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnMakniFiltriranje = new System.Windows.Forms.Button();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.btnAzurirajProizvod = new System.Windows.Forms.Button();
            this.btnObrisiProizvod = new System.Windows.Forms.Button();
            this.btnTrgovina = new System.Windows.Forms.Button();
            this.btnNabaviRobu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKatalog
            // 
            this.dgvKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKatalog.Location = new System.Drawing.Point(12, 64);
            this.dgvKatalog.Name = "dgvKatalog";
            this.dgvKatalog.RowHeadersWidth = 51;
            this.dgvKatalog.RowTemplate.Height = 24;
            this.dgvKatalog.Size = new System.Drawing.Size(776, 299);
            this.dgvKatalog.TabIndex = 0;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(12, 24);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cmbKategorija.TabIndex = 1;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(151, 10);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(85, 48);
            this.btnFiltriraj.TabIndex = 2;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnMakniFiltriranje
            // 
            this.btnMakniFiltriranje.Location = new System.Drawing.Point(242, 10);
            this.btnMakniFiltriranje.Name = "btnMakniFiltriranje";
            this.btnMakniFiltriranje.Size = new System.Drawing.Size(85, 48);
            this.btnMakniFiltriranje.TabIndex = 3;
            this.btnMakniFiltriranje.Text = "Makni filtriranje";
            this.btnMakniFiltriranje.UseVisualStyleBackColor = true;
            this.btnMakniFiltriranje.Click += new System.EventHandler(this.btnMakniFiltriranje_Click);
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(12, 369);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(75, 55);
            this.btnDodajProizvod.TabIndex = 4;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // btnAzurirajProizvod
            // 
            this.btnAzurirajProizvod.Location = new System.Drawing.Point(93, 369);
            this.btnAzurirajProizvod.Name = "btnAzurirajProizvod";
            this.btnAzurirajProizvod.Size = new System.Drawing.Size(75, 54);
            this.btnAzurirajProizvod.TabIndex = 5;
            this.btnAzurirajProizvod.Text = "Ažuriraj proizvod";
            this.btnAzurirajProizvod.UseVisualStyleBackColor = true;
            this.btnAzurirajProizvod.Click += new System.EventHandler(this.btnAzurirajProizvod_Click);
            // 
            // btnObrisiProizvod
            // 
            this.btnObrisiProizvod.Location = new System.Drawing.Point(174, 369);
            this.btnObrisiProizvod.Name = "btnObrisiProizvod";
            this.btnObrisiProizvod.Size = new System.Drawing.Size(75, 55);
            this.btnObrisiProizvod.TabIndex = 6;
            this.btnObrisiProizvod.Text = "Obriši proizvod";
            this.btnObrisiProizvod.UseVisualStyleBackColor = true;
            this.btnObrisiProizvod.Click += new System.EventHandler(this.btnObrisiProizvod_Click);
            // 
            // btnTrgovina
            // 
            this.btnTrgovina.Location = new System.Drawing.Point(632, 369);
            this.btnTrgovina.Name = "btnTrgovina";
            this.btnTrgovina.Size = new System.Drawing.Size(75, 58);
            this.btnTrgovina.TabIndex = 7;
            this.btnTrgovina.Text = "Otvori trgovinu";
            this.btnTrgovina.UseVisualStyleBackColor = true;
            this.btnTrgovina.Click += new System.EventHandler(this.btnTrgovina_Click);
            // 
            // btnNabaviRobu
            // 
            this.btnNabaviRobu.Location = new System.Drawing.Point(713, 370);
            this.btnNabaviRobu.Name = "btnNabaviRobu";
            this.btnNabaviRobu.Size = new System.Drawing.Size(75, 56);
            this.btnNabaviRobu.TabIndex = 8;
            this.btnNabaviRobu.Text = "Nabavi robu";
            this.btnNabaviRobu.UseVisualStyleBackColor = true;
            this.btnNabaviRobu.Click += new System.EventHandler(this.btnNabaviRobu_Click);
            // 
            // FrmPregledProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNabaviRobu);
            this.Controls.Add(this.btnTrgovina);
            this.Controls.Add(this.btnObrisiProizvod);
            this.Controls.Add(this.btnAzurirajProizvod);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.btnMakniFiltriranje);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.dgvKatalog);
            this.Name = "FrmPregledProizvoda";
            this.Text = "Pregled proizvoda";
            this.Load += new System.EventHandler(this.FrmPregledProizvoda_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPregledProizvoda_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKatalog;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnMakniFiltriranje;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Button btnAzurirajProizvod;
        private System.Windows.Forms.Button btnObrisiProizvod;
        private System.Windows.Forms.Button btnTrgovina;
        private System.Windows.Forms.Button btnNabaviRobu;
    }
}

