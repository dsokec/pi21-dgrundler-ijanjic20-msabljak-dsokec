
namespace ItronicStore
{
    partial class PovratnaInformacija
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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvPovratneInformacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrojRedaka = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovratneInformacije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNatrag.Location = new System.Drawing.Point(1131, 549);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(99, 38);
            this.btnNatrag.TabIndex = 27;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvPovratneInformacije
            // 
            this.dgvPovratneInformacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovratneInformacije.Location = new System.Drawing.Point(12, 119);
            this.dgvPovratneInformacije.Name = "dgvPovratneInformacije";
            this.dgvPovratneInformacije.RowHeadersWidth = 62;
            this.dgvPovratneInformacije.RowTemplate.Height = 28;
            this.dgvPovratneInformacije.Size = new System.Drawing.Size(1217, 393);
            this.dgvPovratneInformacije.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Inbox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(957, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ovdje se nalaze sve povratne informacije na Vaše zadane prigovore na odabrane pro" +
    "izvode iz trgovine Itronic";
            // 
            // lblBrojRedaka
            // 
            this.lblBrojRedaka.AutoSize = true;
            this.lblBrojRedaka.Location = new System.Drawing.Point(125, 528);
            this.lblBrojRedaka.Name = "lblBrojRedaka";
            this.lblBrojRedaka.Size = new System.Drawing.Size(51, 20);
            this.lblBrojRedaka.TabIndex = 31;
            this.lblBrojRedaka.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Broj redaka:";
            // 
            // PovratnaInformacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1242, 599);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBrojRedaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPovratneInformacije);
            this.Controls.Add(this.btnNatrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PovratnaInformacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Povratna informacija";
            this.Load += new System.EventHandler(this.PovratnaInformacija_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PovratnaInformacija_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovratneInformacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dgvPovratneInformacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrojRedaka;
        private System.Windows.Forms.Label label3;
    }
}