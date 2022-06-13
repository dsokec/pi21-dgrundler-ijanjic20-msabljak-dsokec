
namespace ItronicStore
{
    partial class ReklamacijaWF
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvReklamacija = new System.Windows.Forms.DataGridView();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIDKorisnik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxIDProizvod = new System.Windows.Forms.ComboBox();
            this.comboBoxIDKorisnik = new System.Windows.Forms.ComboBox();
            this.comboBoxIDRacun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReklamacija)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(157, 69);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(280, 26);
            this.textBoxID.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID";
            // 
            // dgvReklamacija
            // 
            this.dgvReklamacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReklamacija.Location = new System.Drawing.Point(461, 12);
            this.dgvReklamacija.Name = "dgvReklamacija";
            this.dgvReklamacija.RowHeadersWidth = 62;
            this.dgvReklamacija.RowTemplate.Height = 28;
            this.dgvReklamacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReklamacija.Size = new System.Drawing.Size(504, 562);
            this.dgvReklamacija.TabIndex = 33;
            //this.dgvReklamacija.SelectionChanged += new System.EventHandler(this.dgvReklamacija_SelectionChanged);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(157, 477);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(280, 97);
            this.textBoxOpis.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID Proizvod";
            // 
            // labelIDKorisnik
            // 
            this.labelIDKorisnik.AutoSize = true;
            this.labelIDKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDKorisnik.Location = new System.Drawing.Point(45, 188);
            this.labelIDKorisnik.Name = "labelIDKorisnik";
            this.labelIDKorisnik.Size = new System.Drawing.Size(106, 25);
            this.labelIDKorisnik.TabIndex = 27;
            this.labelIDKorisnik.Text = "ID Korisnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID Račun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Reklamacija";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(866, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 38);
            this.button4.TabIndex = 39;
            this.button4.Text = "Odustani";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(362, 599);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 38);
            this.btnObrisi.TabIndex = 38;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(270, 599);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 38);
            this.btnUredi.TabIndex = 37;
            this.btnUredi.Text = "Ažuriraj";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(157, 305);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(280, 26);
            this.textBoxIme.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ime";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(157, 363);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(280, 26);
            this.textBoxPrezime.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Prezime";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(157, 420);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(280, 26);
            this.textBoxEmail.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 46;
            this.button1.Text = "Novi zapis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxIDProizvod
            // 
            this.comboBoxIDProizvod.FormattingEnabled = true;
            this.comboBoxIDProizvod.Location = new System.Drawing.Point(157, 124);
            this.comboBoxIDProizvod.Name = "comboBoxIDProizvod";
            this.comboBoxIDProizvod.Size = new System.Drawing.Size(280, 28);
            this.comboBoxIDProizvod.TabIndex = 47;
            // 
            // comboBoxIDKorisnik
            // 
            this.comboBoxIDKorisnik.FormattingEnabled = true;
            this.comboBoxIDKorisnik.Location = new System.Drawing.Point(157, 188);
            this.comboBoxIDKorisnik.Name = "comboBoxIDKorisnik";
            this.comboBoxIDKorisnik.Size = new System.Drawing.Size(280, 28);
            this.comboBoxIDKorisnik.TabIndex = 48;
            // 
            // comboBoxIDRacun
            // 
            this.comboBoxIDRacun.FormattingEnabled = true;
            this.comboBoxIDRacun.Location = new System.Drawing.Point(157, 244);
            this.comboBoxIDRacun.Name = "comboBoxIDRacun";
            this.comboBoxIDRacun.Size = new System.Drawing.Size(280, 28);
            this.comboBoxIDRacun.TabIndex = 49;
            this.comboBoxIDRacun.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDRacun_SelectedIndexChanged);
            // 
            // ReklamacijaWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 639);
            this.Controls.Add(this.comboBoxIDRacun);
            this.Controls.Add(this.comboBoxIDKorisnik);
            this.Controls.Add(this.comboBoxIDProizvod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvReklamacija);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelIDKorisnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReklamacijaWF";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReklamacijaWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReklamacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvReklamacija;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIDKorisnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxIDProizvod;
        private System.Windows.Forms.ComboBox comboBoxIDKorisnik;
        private System.Windows.Forms.ComboBox comboBoxIDRacun;
    }
}

