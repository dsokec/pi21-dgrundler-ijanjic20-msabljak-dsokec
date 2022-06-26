
namespace ItronicStore
{
    partial class GrafickiPrikaz
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPrihod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartPrihod = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrihod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafički prikaz rada trgovine Itronic";
            // 
            // cmbPrihod
            // 
            this.cmbPrihod.FormattingEnabled = true;
            this.cmbPrihod.Items.AddRange(new object[] {
            "Prihodi",
            "Rashodi",
            "Prihodi vs. Rashodi",
            "Prodano vs. Nabavljeno"});
            this.cmbPrihod.Location = new System.Drawing.Point(386, 87);
            this.cmbPrihod.Name = "cmbPrihod";
            this.cmbPrihod.Size = new System.Drawing.Size(242, 28);
            this.cmbPrihod.TabIndex = 17;
            this.cmbPrihod.SelectedIndexChanged += new System.EventHandler(this.cmbPrihod_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(204, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Odaberi stavku";
            // 
            // chartPrihod
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrihod.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrihod.Legends.Add(legend1);
            this.chartPrihod.Location = new System.Drawing.Point(38, 145);
            this.chartPrihod.Name = "chartPrihod";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPrihod.Series.Add(series1);
            this.chartPrihod.Size = new System.Drawing.Size(862, 472);
            this.chartPrihod.TabIndex = 19;
            this.chartPrihod.Text = "chart1";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(803, 636);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(97, 44);
            this.btnNatrag.TabIndex = 20;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // GrafickiPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 698);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.chartPrihod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPrihod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrafickiPrikaz";
            this.Text = "Obračun";
            this.Load += new System.EventHandler(this.FinancijeWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrihod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPrihod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrihod;
        private System.Windows.Forms.Button btnNatrag;
    }
}