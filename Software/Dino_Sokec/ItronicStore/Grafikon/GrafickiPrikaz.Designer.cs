﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUcitajA = new System.Windows.Forms.Button();
            this.cmbRashod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartRashod = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbPrihod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUcitajB = new System.Windows.Forms.Button();
            this.chartPrihod = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartRashod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrihod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(104, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafički prikaz rada trgovine Itronic";
            // 
            // btnUcitajA
            // 
            this.btnUcitajA.Location = new System.Drawing.Point(38, 495);
            this.btnUcitajA.Name = "btnUcitajA";
            this.btnUcitajA.Size = new System.Drawing.Size(99, 38);
            this.btnUcitajA.TabIndex = 15;
            this.btnUcitajA.Text = "Ucitaj";
            this.btnUcitajA.UseVisualStyleBackColor = true;
            this.btnUcitajA.Click += new System.EventHandler(this.btnUcitajA_Click);
            // 
            // cmbRashod
            // 
            this.cmbRashod.FormattingEnabled = true;
            this.cmbRashod.Location = new System.Drawing.Point(882, 101);
            this.cmbRashod.Name = "cmbRashod";
            this.cmbRashod.Size = new System.Drawing.Size(242, 28);
            this.cmbRashod.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Odaberi stavku";
            // 
            // chartRashod
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRashod.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRashod.Legends.Add(legend3);
            this.chartRashod.Location = new System.Drawing.Point(645, 166);
            this.chartRashod.Name = "chartRashod";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Rashod";
            this.chartRashod.Series.Add(series3);
            this.chartRashod.Size = new System.Drawing.Size(613, 341);
            this.chartRashod.TabIndex = 16;
            this.chartRashod.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Rashod";
            this.chartRashod.Titles.Add(title2);
            // 
            // cmbPrihod
            // 
            this.cmbPrihod.FormattingEnabled = true;
            this.cmbPrihod.Location = new System.Drawing.Point(236, 96);
            this.cmbPrihod.Name = "cmbPrihod";
            this.cmbPrihod.Size = new System.Drawing.Size(242, 28);
            this.cmbPrihod.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(54, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Odaberi stavku";
            // 
            // btnUcitajB
            // 
            this.btnUcitajB.Location = new System.Drawing.Point(1148, 529);
            this.btnUcitajB.Name = "btnUcitajB";
            this.btnUcitajB.Size = new System.Drawing.Size(99, 38);
            this.btnUcitajB.TabIndex = 15;
            this.btnUcitajB.Text = "Ucitaj";
            this.btnUcitajB.UseVisualStyleBackColor = true;
            this.btnUcitajB.Click += new System.EventHandler(this.btnUcitajB_Click);
            // 
            // chartPrihod
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPrihod.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPrihod.Legends.Add(legend4);
            this.chartPrihod.Location = new System.Drawing.Point(38, 166);
            this.chartPrihod.Name = "chartPrihod";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPrihod.Series.Add(series4);
            this.chartPrihod.Size = new System.Drawing.Size(561, 300);
            this.chartPrihod.TabIndex = 19;
            this.chartPrihod.Text = "chart1";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(510, 509);
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
            this.ClientSize = new System.Drawing.Size(1270, 579);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.chartPrihod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPrihod);
            this.Controls.Add(this.cmbRashod);
            this.Controls.Add(this.chartRashod);
            this.Controls.Add(this.btnUcitajB);
            this.Controls.Add(this.btnUcitajA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrafickiPrikaz";
            this.Text = "Obračun";
            this.Load += new System.EventHandler(this.FinancijeWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRashod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrihod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUcitajA;
        private System.Windows.Forms.ComboBox cmbRashod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRashod;
        private System.Windows.Forms.ComboBox cmbPrihod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUcitajB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrihod;
        private System.Windows.Forms.Button btnNatrag;
    }
}