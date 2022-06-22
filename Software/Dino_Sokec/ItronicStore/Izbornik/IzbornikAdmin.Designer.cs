
namespace ItronicStore
{
    partial class IzbornikAdmin
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
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnGrafickiPrikaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrijavljeniKao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInbox
            // 
            this.btnInbox.ForeColor = System.Drawing.Color.Red;
            this.btnInbox.Location = new System.Drawing.Point(49, 98);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(89, 42);
            this.btnInbox.TabIndex = 2;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // btnGrafickiPrikaz
            // 
            this.btnGrafickiPrikaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGrafickiPrikaz.Location = new System.Drawing.Point(260, 100);
            this.btnGrafickiPrikaz.Name = "btnGrafickiPrikaz";
            this.btnGrafickiPrikaz.Size = new System.Drawing.Size(95, 40);
            this.btnGrafickiPrikaz.TabIndex = 2;
            this.btnGrafickiPrikaz.Text = "Grafikon";
            this.btnGrafickiPrikaz.UseVisualStyleBackColor = true;
            this.btnGrafickiPrikaz.Click += new System.EventHandler(this.btnGrafickiPrikaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pristigle reklamacije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(239, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grafički prikaz";
            // 
            // lblPrijavljeniKao
            // 
            this.lblPrijavljeniKao.AutoSize = true;
            this.lblPrijavljeniKao.Location = new System.Drawing.Point(13, 201);
            this.lblPrijavljeniKao.Name = "lblPrijavljeniKao";
            this.lblPrijavljeniKao.Size = new System.Drawing.Size(150, 20);
            this.lblPrijavljeniKao.TabIndex = 3;
            this.lblPrijavljeniKao.Text = "Vi ste prijavljeni kao ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Administracija";
            // 
            // IzbornikAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrijavljeniKao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGrafickiPrikaz);
            this.Controls.Add(this.btnInbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IzbornikAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IzbornikAdmin";
            this.Load += new System.EventHandler(this.IzbornikAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnGrafickiPrikaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrijavljeniKao;
        private System.Windows.Forms.Label label3;
    }
}