
namespace Itronic
{
    partial class FrmAzurirajProizvod
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblKupovnaCijena = new System.Windows.Forms.Label();
            this.lblProdajnaCijena = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.txtProdajnaCijena = new System.Windows.Forms.TextBox();
            this.txtKupovnaCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(330, 395);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(91, 35);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(233, 395);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(91, 35);
            this.btnDodaj.TabIndex = 22;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpis.Location = new System.Drawing.Point(12, 171);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(48, 18);
            this.lblOpis.TabIndex = 21;
            this.lblOpis.Text = "Opis:";
            // 
            // lblKupovnaCijena
            // 
            this.lblKupovnaCijena.AutoSize = true;
            this.lblKupovnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKupovnaCijena.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKupovnaCijena.Location = new System.Drawing.Point(206, 97);
            this.lblKupovnaCijena.Name = "lblKupovnaCijena";
            this.lblKupovnaCijena.Size = new System.Drawing.Size(127, 18);
            this.lblKupovnaCijena.TabIndex = 20;
            this.lblKupovnaCijena.Text = "Kupovna cijena:";
            // 
            // lblProdajnaCijena
            // 
            this.lblProdajnaCijena.AutoSize = true;
            this.lblProdajnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProdajnaCijena.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProdajnaCijena.Location = new System.Drawing.Point(12, 97);
            this.lblProdajnaCijena.Name = "lblProdajnaCijena";
            this.lblProdajnaCijena.Size = new System.Drawing.Size(129, 18);
            this.lblProdajnaCijena.TabIndex = 19;
            this.lblProdajnaCijena.Text = "Prodajna cijena:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNaziv.Location = new System.Drawing.Point(206, 19);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(55, 18);
            this.lblNaziv.TabIndex = 18;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKategorija.Location = new System.Drawing.Point(12, 19);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(89, 18);
            this.lblKategorija.TabIndex = 17;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // txtProdajnaCijena
            // 
            this.txtProdajnaCijena.Location = new System.Drawing.Point(15, 130);
            this.txtProdajnaCijena.Name = "txtProdajnaCijena";
            this.txtProdajnaCijena.Size = new System.Drawing.Size(100, 22);
            this.txtProdajnaCijena.TabIndex = 16;
            // 
            // txtKupovnaCijena
            // 
            this.txtKupovnaCijena.Location = new System.Drawing.Point(209, 130);
            this.txtKupovnaCijena.Name = "txtKupovnaCijena";
            this.txtKupovnaCijena.Size = new System.Drawing.Size(100, 22);
            this.txtKupovnaCijena.TabIndex = 15;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(209, 51);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(212, 22);
            this.txtNaziv.TabIndex = 14;
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(15, 205);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(406, 170);
            this.rtxtOpis.TabIndex = 13;
            this.rtxtOpis.Text = "";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(15, 49);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cmbKategorija.TabIndex = 12;
            // 
            // FrmAzurirajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(450, 449);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblKupovnaCijena);
            this.Controls.Add(this.lblProdajnaCijena);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.txtProdajnaCijena);
            this.Controls.Add(this.txtKupovnaCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.cmbKategorija);
            this.Name = "FrmAzurirajProizvod";
            this.Text = "Ažuriranje proizvoda";
            this.Load += new System.EventHandler(this.FrmAzurirajProizvod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblKupovnaCijena;
        private System.Windows.Forms.Label lblProdajnaCijena;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.TextBox txtProdajnaCijena;
        private System.Windows.Forms.TextBox txtKupovnaCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.ComboBox cmbKategorija;
    }
}