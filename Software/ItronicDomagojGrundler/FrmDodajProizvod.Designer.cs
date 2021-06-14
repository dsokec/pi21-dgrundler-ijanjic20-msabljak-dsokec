
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
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKupovnaCijena = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKupovnaCijena = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.txtProdajnaCijena = new System.Windows.Forms.TextBox();
            this.lblProdajnaCijena = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.msHelp = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItronicManual = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(15, 76);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(155, 24);
            this.cbKategorija.TabIndex = 0;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKategorija.Location = new System.Drawing.Point(12, 47);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(89, 18);
            this.lblKategorija.TabIndex = 1;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNaziv.Location = new System.Drawing.Point(218, 47);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(55, 18);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblKupovnaCijena
            // 
            this.lblKupovnaCijena.AutoSize = true;
            this.lblKupovnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKupovnaCijena.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKupovnaCijena.Location = new System.Drawing.Point(12, 121);
            this.lblKupovnaCijena.Name = "lblKupovnaCijena";
            this.lblKupovnaCijena.Size = new System.Drawing.Size(127, 18);
            this.lblKupovnaCijena.TabIndex = 3;
            this.lblKupovnaCijena.Text = "Kupovna cijena:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOpis.Location = new System.Drawing.Point(12, 183);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(48, 18);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Opis:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(221, 76);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(209, 22);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtKupovnaCijena
            // 
            this.txtKupovnaCijena.Location = new System.Drawing.Point(15, 150);
            this.txtKupovnaCijena.Name = "txtKupovnaCijena";
            this.txtKupovnaCijena.Size = new System.Drawing.Size(100, 22);
            this.txtKupovnaCijena.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(15, 203);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(440, 189);
            this.rtxtOpis.TabIndex = 11;
            this.rtxtOpis.Text = "";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(241, 398);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(104, 56);
            this.btnDodajProizvod.TabIndex = 13;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // txtProdajnaCijena
            // 
            this.txtProdajnaCijena.Location = new System.Drawing.Point(221, 150);
            this.txtProdajnaCijena.Name = "txtProdajnaCijena";
            this.txtProdajnaCijena.Size = new System.Drawing.Size(100, 22);
            this.txtProdajnaCijena.TabIndex = 14;
            // 
            // lblProdajnaCijena
            // 
            this.lblProdajnaCijena.AutoSize = true;
            this.lblProdajnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProdajnaCijena.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProdajnaCijena.Location = new System.Drawing.Point(218, 121);
            this.lblProdajnaCijena.Name = "lblProdajnaCijena";
            this.lblProdajnaCijena.Size = new System.Drawing.Size(129, 18);
            this.lblProdajnaCijena.TabIndex = 15;
            this.lblProdajnaCijena.Text = "Prodajna cijena:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(351, 398);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(104, 56);
            this.btnOdustani.TabIndex = 16;
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
            this.msHelp.Size = new System.Drawing.Size(464, 28);
            this.msHelp.TabIndex = 17;
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
            // FrmDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(464, 467);
            this.Controls.Add(this.msHelp);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblProdajnaCijena);
            this.Controls.Add(this.txtProdajnaCijena);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.txtKupovnaCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblKupovnaCijena);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.cbKategorija);
            this.Name = "FrmDodajProizvod";
            this.Text = "Dodaj proizvod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDodajProizvod_FormClosed);
            this.Load += new System.EventHandler(this.FrmDodajProizvod_Load);
            this.msHelp.ResumeLayout(false);
            this.msHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKupovnaCijena;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKupovnaCijena;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.TextBox txtProdajnaCijena;
        private System.Windows.Forms.Label lblProdajnaCijena;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.MenuStrip msHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiItronicManual;
    }
}