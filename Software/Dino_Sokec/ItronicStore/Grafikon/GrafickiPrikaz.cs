using ClassLibrary2.ToolBox;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            UcitajPrihode();
            PostaviReadOnlyComboBox();
            PrikaziPrvuStavkuComboBoxa();
        }

        private void PrikaziPrvuStavkuComboBoxa()
        {
            cmbPrihod.SelectedIndex = 0;
        }

        private void PostaviReadOnlyComboBox()
        {
            cmbPrihod.DropDownStyle = ComboBoxStyle.DropDownList;
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

        // Prihodi kroz godine
        private void btnUcitajA_Click(object sender, EventArgs e)
        {
            chartPrihod.Series.Clear();
            chartPrihod.Series.Add("Obracun");
            chartPrihod.Series["Godina"].XValueMember = "Godina";
            //chartPrihod.Series["Obracun].XValueMember = "Godina";
            //chartPrihod.Series["Godina"].Points.AddXY("Godina",)

            //chartPrihod.Series.Add("Prihod");
            chartPrihod.Series["Obracun"].XValueMember = "Prihod";
            //chartPrihod.Series["Obracun"].XValueMember = "Prihod";


            chartPrihod.DataSource = null;
            chartPrihod.DataSource = ClassLibrary2.ToolBox.TOOL_Grafikon.DohvatiPrihodKrozGodine();
            
            //chartPrihod.Series["Prihod"].YValueMember = "Prihod";
            //chartPrihod.Series["Prihod"].YValueMember = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            //var series = chartPrihod.Series.Add("series");
            //series.XValueMember = "jedan";
            //series.YValueMembers = "dva";
            //series.Name = "Prihod trgovine";

            //chartPrihod.DataSource = ClassLibrary2.ToolBox.TOOL_Grafikon.DohvatiPrihodKrozGodine();
            //chartPrihod.Series["Godina"].XValueMember = "Godina";
            //chartPrihod.Series["Prihod"].YValueMembers = "Prihod";
            //chartPrihod.Series.Add("Godina");
            //chartPrihod.Series.Add("Prihod");

        }

        // Rashodi kroz godine
        //private void btnUcitajB_Click(object sender, EventArgs e)
        //{
        //    chartRashod.Series["Godina"].XValueMember = "Godina";
        //    chartRashod.Series["Prihod"].YValueMembers = "Rashod";
        //    chartRashod.DataSource = ClassLibrary2.ToolBox.TOOL_Grafikon.DohvatiRashodKrozGodine();
        //}

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void cmbPrihod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int odabir = cmbPrihod.SelectedIndex;
            if(odabir == 1)
            {
                UcitajPrihode();
            }
            else if(odabir == 2)
            {
                UcitajRashode();
            }
            else if(odabir == 3)
            {
                UcitajPrihodevsRashode();
            }
            else
            {
                UcitajProdanovsNabavljeno();
            }
        }

        private void UcitajRashode()
        {
            throw new NotImplementedException();
        }

        private void UcitajPrihodevsRashode()
        {
            throw new NotImplementedException();
        }

        private void UcitajProdanovsNabavljeno()
        {
            throw new NotImplementedException();
        }
    }
}
