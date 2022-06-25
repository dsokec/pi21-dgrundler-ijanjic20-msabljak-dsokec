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
        private wfLogin login;
        private IzbornikAdmin IzbornikAdmin;
        private string korisnickoImeAdmina;
        public AdminPrijava(wfLogin login)
        {
            InitializeComponent();
            this.login = login;
            login.Hide();
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
            Owner.Show();
            Hide();
        }

        private void btnPrijaviSeAdmin_Click(object sender, EventArgs e)
        {
            string odabraniAdmin = DohvatiOdabranogAdmina();
            
            korisnickoImeAdmina = TOOL_Administrator.DohvatiKorisnickoImeAdministratora(odabraniAdmin);
            if(IzbornikAdmin == null)
            {
                IzbornikAdmin = new IzbornikAdmin(this,korisnickoImeAdmina);
                IzbornikAdmin.FormClosed += IzbornikAdmin_FormClosed;
            }
            IzbornikAdmin.Show(this);
            Hide();
        }

        private string DohvatiOdabranogAdmina()
        {
            string odabraniAdmin = cmbImeAdmina.SelectedItem.ToString();
            return odabraniAdmin;
        }

        private void IzbornikAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            IzbornikAdmin = null;
            Show();
        }
    }
}
