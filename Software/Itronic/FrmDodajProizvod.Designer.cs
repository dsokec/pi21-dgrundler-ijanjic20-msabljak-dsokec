
namespace Itronic
{
    partial class FrmDodajProizvod
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
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKupovnaCijena = new System.Windows.Forms.TextBox();
            this.txtPocetnaCijena = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblProdajnaCijena = new System.Windows.Forms.Label();
            this.lblKupovnaCijena = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(32, 58);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cmbKategorija.TabIndex = 0;
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(32, 214);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(406, 170);
            this.rtxtOpis.TabIndex = 1;
            this.rtxtOpis.Text = "";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(226, 60);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(212, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtKupovnaCijena
            // 
            this.txtKupovnaCijena.Location = new System.Drawing.Point(32, 137);
            this.txtKupovnaCijena.Name = "txtKupovnaCijena";
            this.txtKupovnaCijena.Size = new System.Drawing.Size(100, 22);
            this.txtKupovnaCijena.TabIndex = 3;
            // 
            // txtPocetnaCijena
            // 
            this.txtPocetnaCijena.Location = new System.Drawing.Point(226, 137);
            this.txtPocetnaCijena.Name = "txtPocetnaCijena";
            this.txtPocetnaCijena.Size = new System.Drawing.Size(100, 22);
            this.txtPocetnaCijena.TabIndex = 4;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKategorija.Location = new System.Drawing.Point(29, 28);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(89, 18);
            this.lblKategorija.TabIndex = 5;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNaziv.Location = new System.Drawing.Point(223, 28);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(55, 18);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblProdajnaCijena
            // 
            this.lblProdajnaCijena.AutoSize = true;
            this.lblProdajnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProdajnaCijena.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProdajnaCijena.Location = new System.Drawing.Point(29, 106);
            this.lblProdajnaCijena.Name = "lblProdajnaCijena";
            this.lblProdajnaCijena.Size = new System.Drawing.Size(129, 18);
            this.lblProdajnaCijena.TabIndex = 7;
            this.lblProdajnaCijena.Text = "Prodajna cijena:";
            // 
            // lblKupovnaCijena
            // 
            this.lblKupovnaCijena.AutoSize = true;
            this.lblKupovnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKupovnaCijena.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKupovnaCijena.Location = new System.Drawing.Point(223, 106);
            this.lblKupovnaCijena.Name = "lblKupovnaCijena";
            this.lblKupovnaCijena.Size = new System.Drawing.Size(127, 18);
            this.lblKupovnaCijena.TabIndex = 8;
            this.lblKupovnaCijena.Text = "Kupovna cijena:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpis.Location = new System.Drawing.Point(29, 180);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(48, 18);
            this.lblOpis.TabIndex = 9;
            this.lblOpis.Text = "Opis:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(250, 404);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(91, 35);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(347, 404);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(91, 35);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // FrmDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(466, 451);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblKupovnaCijena);
            this.Controls.Add(this.lblProdajnaCijena);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.txtPocetnaCijena);
            this.Controls.Add(this.txtKupovnaCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.cmbKategorija);
            this.Name = "FrmDodajProizvod";
            this.Text = "Dodavanje proizvoda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKupovnaCijena;
        private System.Windows.Forms.TextBox txtPocetnaCijena;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblProdajnaCijena;
        private System.Windows.Forms.Label lblKupovnaCijena;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}