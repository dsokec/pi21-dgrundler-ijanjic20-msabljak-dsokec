using ClassLibrary2.ToolBox;
using System;
using System.Windows.Forms;

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
            chartPrihod.Series["Godina"].XValueMember = "Godina";
            chartPrihod.Series["Prihod"].YValueMembers = "Prihod";
            chartPrihod.DataSource = ClassLibrary2.ToolBox.TOOL_Grafikon.DohvatiPrihodKrozGodine();
        }

        // Rashodi kroz godine
        private void btnUcitajB_Click(object sender, EventArgs e)
        {
            chartRashod.Series["Godina"].XValueMember = "Godina";
            chartRashod.Series["Prihod"].YValueMembers = "Rashod";
            chartRashod.DataSource = ClassLibrary2.ToolBox.TOOL_Grafikon.DohvatiRashodKrozGodine();
        }
    }
}
