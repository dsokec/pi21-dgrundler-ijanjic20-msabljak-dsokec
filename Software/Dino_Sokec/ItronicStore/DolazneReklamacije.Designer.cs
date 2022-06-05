
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
            this.dgvPopisReklamacija.Location = new System.Drawing.Point(12, 89);
            this.dgvPopisReklamacija.Name = "dgvPopisReklamacija";
            this.dgvPopisReklamacija.RowHeadersWidth = 62;
            this.dgvPopisReklamacija.RowTemplate.Height = 28;
            this.dgvPopisReklamacija.Size = new System.Drawing.Size(658, 426);
            this.dgvPopisReklamacija.TabIndex = 0;
            // 
            // cmbFiltar
            // 
            this.cmbFiltar.FormattingEnabled = true;
            this.cmbFiltar.Location = new System.Drawing.Point(12, 562);
            this.cmbFiltar.Name = "cmbFiltar";
            this.cmbFiltar.Size = new System.Drawing.Size(154, 28);
            this.cmbFiltar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtriraj pretragu";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(595, 543);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 35);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(474, 543);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(86, 35);
            this.btnNaprijed.TabIndex = 3;
            this.btnNaprijed.Text = "Odaberi";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dolazne reklamacije";
            // 
            // lblPrijavljenKao
            // 
            this.lblPrijavljenKao.AutoSize = true;
            this.lblPrijavljenKao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljenKao.Location = new System.Drawing.Point(393, 45);
            this.lblPrijavljenKao.Name = "lblPrijavljenKao";
            this.lblPrijavljenKao.Size = new System.Drawing.Size(283, 25);
            this.lblPrijavljenKao.TabIndex = 5;
            this.lblPrijavljenKao.Text = "Prijavljen kao: <naziv_admina>";
            // 
            // DolazneReklamacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 605);
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