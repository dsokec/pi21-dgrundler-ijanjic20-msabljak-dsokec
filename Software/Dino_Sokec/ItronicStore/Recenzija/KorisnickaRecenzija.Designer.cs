
namespace ItronicStore
{
    partial class KorisnickaRecenzija
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
            this.dgvPopisProizvoda = new System.Windows.Forms.DataGridView();
            this.txtboxKomentar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.radioB1 = new System.Windows.Forms.RadioButton();
            this.radioB2 = new System.Windows.Forms.RadioButton();
            this.radioB3 = new System.Windows.Forms.RadioButton();
            this.radioB4 = new System.Windows.Forms.RadioButton();
            this.radioB5 = new System.Windows.Forms.RadioButton();
            this.txtPronadjeniProizvod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrazilicaProizvoda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPovijestRecenzija = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBrojRedaka = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBrojRedakaPovijest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisProizvoda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestRecenzija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisProizvoda
            // 
            this.dgvPopisProizvoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisProizvoda.Location = new System.Drawing.Point(468, 93);
            this.dgvPopisProizvoda.Name = "dgvPopisProizvoda";
            this.dgvPopisProizvoda.ReadOnly = true;
            this.dgvPopisProizvoda.RowHeadersWidth = 62;
            this.dgvPopisProizvoda.RowTemplate.Height = 28;
            this.dgvPopisProizvoda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisProizvoda.Size = new System.Drawing.Size(752, 303);
            this.dgvPopisProizvoda.TabIndex = 45;
            this.dgvPopisProizvoda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisProizvoda_CellClick);
            // 
            // txtboxKomentar
            // 
            this.txtboxKomentar.Location = new System.Drawing.Point(117, 385);
            this.txtboxKomentar.Multiline = true;
            this.txtboxKomentar.Name = "txtboxKomentar";
            this.txtboxKomentar.Size = new System.Drawing.Size(250, 97);
            this.txtboxKomentar.TabIndex = 44;
            this.txtboxKomentar.Text = "Aplikacija je odlicna.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(26, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ocjena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(4, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Komentar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Recenzija proizvoda";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(301, 675);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(99, 38);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(77, 502);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 38);
            this.btnSpremi.TabIndex = 48;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // radioB1
            // 
            this.radioB1.AutoSize = true;
            this.radioB1.Location = new System.Drawing.Point(125, 343);
            this.radioB1.Name = "radioB1";
            this.radioB1.Size = new System.Drawing.Size(43, 24);
            this.radioB1.TabIndex = 52;
            this.radioB1.Tag = "1";
            this.radioB1.Text = "1";
            this.radioB1.UseVisualStyleBackColor = true;
            // 
            // radioB2
            // 
            this.radioB2.AutoSize = true;
            this.radioB2.Location = new System.Drawing.Point(174, 343);
            this.radioB2.Name = "radioB2";
            this.radioB2.Size = new System.Drawing.Size(43, 24);
            this.radioB2.TabIndex = 52;
            this.radioB2.Tag = "2";
            this.radioB2.Text = "2";
            this.radioB2.UseVisualStyleBackColor = true;
            // 
            // radioB3
            // 
            this.radioB3.AutoSize = true;
            this.radioB3.Location = new System.Drawing.Point(223, 344);
            this.radioB3.Name = "radioB3";
            this.radioB3.Size = new System.Drawing.Size(43, 24);
            this.radioB3.TabIndex = 52;
            this.radioB3.Tag = "3";
            this.radioB3.Text = "3";
            this.radioB3.UseVisualStyleBackColor = true;
            // 
            // radioB4
            // 
            this.radioB4.AutoSize = true;
            this.radioB4.Location = new System.Drawing.Point(272, 344);
            this.radioB4.Name = "radioB4";
            this.radioB4.Size = new System.Drawing.Size(43, 24);
            this.radioB4.TabIndex = 52;
            this.radioB4.Tag = "4";
            this.radioB4.Text = "4";
            this.radioB4.UseVisualStyleBackColor = true;
            // 
            // radioB5
            // 
            this.radioB5.AutoSize = true;
            this.radioB5.Checked = true;
            this.radioB5.Location = new System.Drawing.Point(321, 344);
            this.radioB5.Name = "radioB5";
            this.radioB5.Size = new System.Drawing.Size(43, 24);
            this.radioB5.TabIndex = 52;
            this.radioB5.TabStop = true;
            this.radioB5.Tag = "5";
            this.radioB5.Text = "5";
            this.radioB5.UseVisualStyleBackColor = true;
            // 
            // txtPronadjeniProizvod
            // 
            this.txtPronadjeniProizvod.Location = new System.Drawing.Point(117, 260);
            this.txtPronadjeniProizvod.Name = "txtPronadjeniProizvod";
            this.txtPronadjeniProizvod.ReadOnly = true;
            this.txtPronadjeniProizvod.Size = new System.Drawing.Size(250, 26);
            this.txtPronadjeniProizvod.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(13, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Proizvod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(726, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tražilica proizvoda";
            // 
            // txtTrazilicaProizvoda
            // 
            this.txtTrazilicaProizvoda.Location = new System.Drawing.Point(618, 60);
            this.txtTrazilicaProizvoda.Name = "txtTrazilicaProizvoda";
            this.txtTrazilicaProizvoda.Size = new System.Drawing.Size(415, 26);
            this.txtTrazilicaProizvoda.TabIndex = 53;
            this.txtTrazilicaProizvoda.TextChanged += new System.EventHandler(this.txtTrazilicaProizvoda_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnAzuriraj);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnSpremi);
            this.groupBox1.Controls.Add(this.txtboxKomentar);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.txtPronadjeniProizvod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioB5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioB4);
            this.groupBox1.Controls.Add(this.radioB2);
            this.groupBox1.Controls.Add(this.radioB3);
            this.groupBox1.Controls.Add(this.radioB1);
            this.groupBox1.Location = new System.Drawing.Point(13, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 560);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(285, 502);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(79, 38);
            this.btnObrisi.TabIndex = 60;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(174, 502);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(80, 38);
            this.btnAzuriraj.TabIndex = 59;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 301);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.Color.Red;
            this.txtPrezime.Location = new System.Drawing.Point(239, 80);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(128, 26);
            this.txtPrezime.TabIndex = 53;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.Red;
            this.txtIme.Location = new System.Drawing.Point(117, 80);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(116, 26);
            this.txtIme.TabIndex = 53;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.Red;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(174, 124);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.ReadOnly = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(193, 26);
            this.txtKorisnickoIme.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(90, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 25);
            this.label14.TabIndex = 38;
            this.label14.Text = "Osobni podatci korisnika";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(65, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(272, 25);
            this.label15.TabIndex = 38;
            this.label15.Text = "Povratna informacija kupca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(13, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Korisnik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(13, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Korisničko ime";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(32, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(760, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Povijest recenzija";
            // 
            // dgvPovijestRecenzija
            // 
            this.dgvPovijestRecenzija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPovijestRecenzija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovijestRecenzija.Location = new System.Drawing.Point(468, 478);
            this.dgvPovijestRecenzija.Name = "dgvPovijestRecenzija";
            this.dgvPovijestRecenzija.ReadOnly = true;
            this.dgvPovijestRecenzija.RowHeadersWidth = 62;
            this.dgvPovijestRecenzija.RowTemplate.Height = 28;
            this.dgvPovijestRecenzija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPovijestRecenzija.Size = new System.Drawing.Size(752, 185);
            this.dgvPovijestRecenzija.TabIndex = 45;
            this.dgvPovijestRecenzija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPovijestRecenzija_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Unesite pojam";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sve",
            "Cijena - Uzlazno",
            "Cijena - Silazno",
            "Naziv - Uzlazno"});
            this.comboBox1.Location = new System.Drawing.Point(1067, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 28);
            this.comboBox1.TabIndex = 57;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1120, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Filtiraj";
            // 
            // lblBrojRedaka
            // 
            this.lblBrojRedaka.AutoSize = true;
            this.lblBrojRedaka.Location = new System.Drawing.Point(589, 417);
            this.lblBrojRedaka.Name = "lblBrojRedaka";
            this.lblBrojRedaka.Size = new System.Drawing.Size(60, 20);
            this.lblBrojRedaka.TabIndex = 58;
            this.lblBrojRedaka.Text = "label11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(464, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 22);
            this.label11.TabIndex = 56;
            this.label11.Text = "Broj redaka:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(464, 682);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 22);
            this.label12.TabIndex = 56;
            this.label12.Text = "Broj redaka:";
            // 
            // lblBrojRedakaPovijest
            // 
            this.lblBrojRedakaPovijest.AutoSize = true;
            this.lblBrojRedakaPovijest.Location = new System.Drawing.Point(589, 684);
            this.lblBrojRedakaPovijest.Name = "lblBrojRedakaPovijest";
            this.lblBrojRedakaPovijest.Size = new System.Drawing.Size(60, 20);
            this.lblBrojRedakaPovijest.TabIndex = 58;
            this.lblBrojRedakaPovijest.Text = "label11";
            // 
            // KorisnickaRecenzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1232, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrojRedakaPovijest);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblBrojRedaka);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTrazilicaProizvoda);
            this.Controls.Add(this.dgvPovijestRecenzija);
            this.Controls.Add(this.dgvPopisProizvoda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KorisnickaRecenzija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recenzija";
            this.Load += new System.EventHandler(this.KorisnickaRecenzija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisProizvoda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestRecenzija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPopisProizvoda;
        private System.Windows.Forms.TextBox txtboxKomentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RadioButton radioB1;
        private System.Windows.Forms.RadioButton radioB2;
        private System.Windows.Forms.RadioButton radioB3;
        private System.Windows.Forms.RadioButton radioB4;
        private System.Windows.Forms.RadioButton radioB5;
        private System.Windows.Forms.TextBox txtPronadjeniProizvod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrazilicaProizvoda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPovijestRecenzija;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBrojRedaka;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBrojRedakaPovijest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
    }
}