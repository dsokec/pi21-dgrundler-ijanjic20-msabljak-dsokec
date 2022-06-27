using ClassLibrary2.ToolBox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ItronicStore;

namespace ItronicStore
{
    public partial class GrafickiPrikaz : Form
    {
        public GrafickiPrikaz()
        {
            InitializeComponent();
        }

        private void FinancijeWF_Load(object sender, EventArgs e)
        {
            PrikaziPrvuStavkuComboBoxa();
            PostaviReadOnlyComboBox();
            UcitajPrihode();
        }

        private void PrikaziPrvuStavkuComboBoxa()
        {
            cmbPrihod.SelectedIndex = 0;
        }

        private void PostaviReadOnlyComboBox()
        {
            cmbPrihod.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void cmbPrihod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int odabir = cmbPrihod.SelectedIndex;
            if(odabir == 0)
            {
                UcitajPrihode();
            }
            else if(odabir == 1)
            {
                UcitajRashode();
            }
            else if(odabir == 2)
            {
                UcitajPrihodevsRashode();
            }
            else
            {
                UcitajProdanovsNabavljeno();
            }
        }
        private void UcitajPrihode()
        {
            chartPrihod.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Prihod trgovine",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
            this.chartPrihod.Series.Add(series1);

            List<int> godine = TOOL_Grafikon.DohvatiGodineIzTabliceObracun();
            List<double> prihodi = TOOL_Grafikon.DohvatiPrihodeIzTabliceObracun();

            series1.Points.Clear();
            chartPrihod.Series["Prihod trgovine"].Points.DataBindXY(godine, prihodi);
            chartPrihod.Invalidate();

        }
        private void UcitajRashode()
        {
            chartPrihod.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Rashod trgovine",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = false,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
            this.chartPrihod.Series.Add(series1);

            List<int> godine = TOOL_Grafikon.DohvatiGodineIzTabliceObracun();
            List<double> rashodi = TOOL_Grafikon.DohvatiRashodeIzTabliceObracun();

            series1.Points.Clear();
            chartPrihod.Series["Rashod trgovine"].Points.DataBindXY(godine, rashodi);
            chartPrihod.Invalidate();
        }

        private void UcitajPrihodevsRashode()
        {
            chartPrihod.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Rashod trgovine",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = true,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Prihod trgovine",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
            this.chartPrihod.Series.Add(series2);
            this.chartPrihod.Series.Add(series1);
            

            List<int> godine = TOOL_Grafikon.DohvatiGodineIzTabliceObracun();
            List<double> rashodi = TOOL_Grafikon.DohvatiRashodeIzTabliceObracun();
            List<double> prihodi = TOOL_Grafikon.DohvatiPrihodeIzTabliceObracun();

            series1.Points.Clear();
            chartPrihod.Series["Rashod trgovine"].Points.DataBindXY(godine, rashodi);
            chartPrihod.Series["Prihod trgovine"].Points.DataBindXY(godine, prihodi);
            chartPrihod.Invalidate();
        }

        private void UcitajProdanovsNabavljeno()
        {
            chartPrihod.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Prodano trgovina",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Nabavljeno trgovina",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = true,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
            this.chartPrihod.Series.Add(series1);
            this.chartPrihod.Series.Add(series2);

            List<int> godine = TOOL_Grafikon.DohvatiGodineIzTabliceObracun();
            List<int> prodano = TOOL_Grafikon.DohvatiProdanoIzTabliceObracun();
            List<int> nabavljeno = TOOL_Grafikon.DohvatiNabavljenoIzTabliceObracun();

            series1.Points.Clear();
            chartPrihod.Series["Prodano trgovina"].Points.DataBindXY(godine, prodano);
            chartPrihod.Series["Nabavljeno trgovina"].Points.DataBindXY(godine, nabavljeno);
            chartPrihod.Invalidate();
        }

        private void GrafickiPrikaz_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OtvoriHelpFile(1070);
        }
        private void OtvoriHelpFile(int id = -1)
        {
            string help = PutanjaDoHelpFile();
            if (id == -1)
            {
                //otvara se naslovna stranicu u help file
                System.Diagnostics.Process.Start(help);
            }
            else
            {
                //otvora se trazena stranica u help file
                Help.ShowHelp(this, help, HelpNavigator.TopicId, id.ToString());
            }
        }

        private string PutanjaDoHelpFile()
        {
            // absolute path
            string putanja = Path.Combine(new Uri(Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");

            return putanja;
        }
    }
}
