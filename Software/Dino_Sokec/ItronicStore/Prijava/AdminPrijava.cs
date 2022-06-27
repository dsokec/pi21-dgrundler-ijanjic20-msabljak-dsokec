using ClassLibrary2.ToolBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItronicStore
{
    public partial class AdminPrijava : Form
    {
        private wfLogin login;
        private IzbornikAdmin IzbornikAdmin;
        private string korisnickoImeAdmina = null;
        public AdminPrijava(wfLogin login)
        {
            InitializeComponent();
            this.login = login;
            login.Hide();
        }

        private void AdminPrijava_Load(object sender, EventArgs e)
        {
            this.Refresh();
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
            this.Refresh();
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

        private void AdminPrijava_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OtvoriHelpFile(1020);
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
