using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using ClassLibrary2;

namespace ItronicStore
{
    public partial class wfLogin : Form
    {
        public wfLogin()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            OtvoriIzbornik();
        }

        private void OtvoriIzbornik()
        {
            string korisnickoIme = cmbKorisnickoIme.Text;
            this.Hide();
            Izbornik form = new Izbornik(korisnickoIme);
            form.ShowDialog();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            NapustanjeAplikacije();
        }

        private void NapustanjeAplikacije()
        {
            string upit = "Jeste li sigurni ?";

            DialogResult odgovor = MessageBox.Show(upit, "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(odgovor == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void wfLogin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OtvoriHelpFile(6000);
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


        private void wfLogin_Load(object sender, EventArgs e)
        {
            NapuniCombobox();
            txtLozinkaLogin.ReadOnly = true;
        }

        private void NapuniCombobox()
        {

        }

        private void cmbKorisnickoIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabir = cmbKorisnickoIme.SelectedItem.ToString();
            txtLozinkaLogin.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new AdminPrijava();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
