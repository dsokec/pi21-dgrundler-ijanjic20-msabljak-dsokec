using ClassLibrary2.ToolBox;
using System;
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
        private void btnUcitajB_Click(object sender, EventArgs e)
        {
            chartRashod.Series["Godina"].XValueMember = "Godina";
            chartRashod.Series["Prihod"].YValueMembers = "Rashod";
            chartRashod.DataSource = ClassLibrary2.ToolBox.TOOL_Grafikon.DohvatiRashodKrozGodine();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }
    }
}
