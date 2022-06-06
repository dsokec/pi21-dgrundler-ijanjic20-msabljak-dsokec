using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItronicStore;

namespace ItronicStore
{
    public partial class NovaReklamacija : Form
    {
        public NovaReklamacija()
        {
            InitializeComponent();
        }
        
        // Odustani
        private void button2_Click(object sender, EventArgs e)
        {
            ObrisiSveTekstualneOkvire();
            this.Close();
        }

        private void ObrisiSveTekstualneOkvire()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void NoviZapisWF_Load(object sender, EventArgs e)
        {
            int zadnjiID = UpravljanjeReklamacijama.DohvatiZadnjuVrijednostIDja();
            textBoxID.Text = (zadnjiID + 1).ToString();
            textBoxID.ReadOnly = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
