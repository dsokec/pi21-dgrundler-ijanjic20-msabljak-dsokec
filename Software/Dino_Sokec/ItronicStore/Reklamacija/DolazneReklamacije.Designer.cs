﻿
namespace ItronicStore
{
    partial class DolazneReklamacije
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
            this.dgvPopisReklamacija = new System.Windows.Forms.DataGridView();
            this.cmbFiltar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblPrijavljenKao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisReklamacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisReklamacija
            // 
            this.dgvPopisReklamacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisReklamacija.Location = new System.Drawing.Point(18, 64);
            this.dgvPopisReklamacija.Name = "dgvPopisReklamacija";
            this.dgvPopisReklamacija.ReadOnly = true;
            this.dgvPopisReklamacija.RowHeadersWidth = 62;
            this.dgvPopisReklamacija.RowTemplate.Height = 28;
            this.dgvPopisReklamacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisReklamacija.Size = new System.Drawing.Size(1113, 261);
            this.dgvPopisReklamacija.TabIndex = 0;
            // 
            // cmbFiltar
            // 
            this.cmbFiltar.FormattingEnabled = true;
            this.cmbFiltar.Items.AddRange(new object[] {
            "Najnovije",
            "Najstarije",
            "Po osobi"});
            this.cmbFiltar.Location = new System.Drawing.Point(196, 18);
            this.cmbFiltar.Name = "cmbFiltar";
            this.cmbFiltar.Size = new System.Drawing.Size(212, 28);
            this.cmbFiltar.TabIndex = 1;
            this.cmbFiltar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtriraj pretragu";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(1056, 795);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 35);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(19, 390);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(86, 35);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // lblPrijavljenKao
            // 
            this.lblPrijavljenKao.AutoSize = true;
            this.lblPrijavljenKao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljenKao.Location = new System.Drawing.Point(818, 24);
            this.lblPrijavljenKao.Name = "lblPrijavljenKao";
            this.lblPrijavljenKao.Size = new System.Drawing.Size(313, 25);
            this.lblPrijavljenKao.TabIndex = 5;
            this.lblPrijavljenKao.Text = "Prijavljen kao: <naziv_admina>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 794);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ažuriraj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 795);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Obriši";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 217);
            this.dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Korisnicko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Proizvod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prigovor";
            // 
            // DolazneReklamacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1143, 854);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrijavljenKao);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltar);
            this.Controls.Add(this.dgvPopisReklamacija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DolazneReklamacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DolazneReklamacije";
            this.Load += new System.EventHandler(this.DolazneReklamacije_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DolazneReklamacije_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisReklamacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisReklamacija;
        private System.Windows.Forms.ComboBox cmbFiltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblPrijavljenKao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}