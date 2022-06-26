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
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrijavljenKao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisReklamacija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisReklamacija
            // 
            this.dgvPopisReklamacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisReklamacija.Location = new System.Drawing.Point(18, 145);
            this.dgvPopisReklamacija.Name = "dgvPopisReklamacija";
            this.dgvPopisReklamacija.ReadOnly = true;
            this.dgvPopisReklamacija.RowHeadersWidth = 62;
            this.dgvPopisReklamacija.RowTemplate.Height = 28;
            this.dgvPopisReklamacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisReklamacija.Size = new System.Drawing.Size(1113, 248);
            this.dgvPopisReklamacija.TabIndex = 0;
            // 
            // cmbFiltar
            // 
            this.cmbFiltar.FormattingEnabled = true;
            this.cmbFiltar.Items.AddRange(new object[] {
            "Najnovije",
            "Najstarije",
            "Po osobi"});
            this.cmbFiltar.Location = new System.Drawing.Point(18, 101);
            this.cmbFiltar.Name = "cmbFiltar";
            this.cmbFiltar.Size = new System.Drawing.Size(212, 28);
            this.cmbFiltar.TabIndex = 1;
            this.cmbFiltar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtriraj pretragu";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(977, 418);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 35);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(846, 418);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(86, 35);
            this.btnNaprijed.TabIndex = 3;
            this.btnNaprijed.Text = "Odaberi";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dolazne reklamacije";
            // 
            // lblPrijavljenKao
            // 
            this.lblPrijavljenKao.AutoSize = true;
            this.lblPrijavljenKao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljenKao.Location = new System.Drawing.Point(742, 104);
            this.lblPrijavljenKao.Name = "lblPrijavljenKao";
            this.lblPrijavljenKao.Size = new System.Drawing.Size(313, 25);
            this.lblPrijavljenKao.TabIndex = 5;
            this.lblPrijavljenKao.Text = "Prijavljen kao: <naziv_admina>";
            // 
            // DolazneReklamacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 472);
            this.Controls.Add(this.lblPrijavljenKao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltar);
            this.Controls.Add(this.dgvPopisReklamacija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DolazneReklamacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DolazneReklamacije";
            this.Load += new System.EventHandler(this.DolazneReklamacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisReklamacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisReklamacija;
        private System.Windows.Forms.ComboBox cmbFiltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrijavljenKao;
    }
}