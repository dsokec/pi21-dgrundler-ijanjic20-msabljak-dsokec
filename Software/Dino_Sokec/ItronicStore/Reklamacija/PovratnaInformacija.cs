using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItronicStore
{
    public partial class PovratnaInformacija : Form
    {
        public PovratnaInformacija()
        {
            InitializeComponent();
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }
    }
}
