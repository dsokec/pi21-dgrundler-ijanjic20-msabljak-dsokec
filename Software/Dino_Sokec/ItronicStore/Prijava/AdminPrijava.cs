using ClassLibrary2.ToolBox;
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
    public partial class AdminPrijava : Form
    {
        public AdminPrijava()
        {
            InitializeComponent();
        }

        private void AdminPrijava_Load(object sender, EventArgs e)
        {
            NapuniComboBoxKorisnickoIme();
            
        }

        private void NapuniComboBoxKorisnickoIme()
        {
            cmbImeAdmina.DataSource = null;
            cmbImeAdmina.DataSource = TOOL_Administrator.DohvatiSveAdministratore();
            cmbImeAdmina.SelectedIndex = 0;

            txtLozinkaAdmin.ReadOnly = true;
        }

        private void cmbImeAdmina_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imeAdmina = cmbImeAdmina.SelectedItem.ToString();
            txtLozinkaAdmin.Text = TOOL_Administrator.DohvatiLozinkuZaOdabranogAdministratora(imeAdmina);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            wfLogin form = new wfLogin();
            form.Show();
        }

        private void btnPrijaviSeAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Izbornik izbornik = new Izbornik();
            izbornik.Show();
        }
    }
}
