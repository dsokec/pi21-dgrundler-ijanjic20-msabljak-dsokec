using ItronicStore;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using KlasaUpravljanja;

namespace Projekt2022
{
    public partial class wfLogin : Form
    {
        public wfLogin()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            // Poruke upozorenja
            string podatciPoruka = "Unesite podatke za prijavu";
            string uspjehPoruka = "Uspjesno ste prijavljeni";
            string neispravnoPoruka = "Neispravno korisnicko ime ili lozinka";

            string g = "Greska";
            string u = "Uspjeh";

            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show(podatciPoruka, g, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ProvjeriPodatkeNaServeru(korisnickoIme, lozinka))
            {
                MessageBox.Show(uspjehPoruka, u, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(neispravnoPoruka, g, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool ProvjeriPodatkeNaServeru(string korisnik, string pass)
        {
            throw new NotImplementedException();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            OtvoriWindowsFormuRegistracija();
        }

        private void OtvoriWindowsFormuRegistracija()
        {
            this.Hide();
            RegistrationWF registration = new RegistrationWF();
            registration.ShowDialog();

            this.Show();
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

        private void wfLogin_Load(object sender, EventArgs e)
        {
            ZapocniUnositiPodatke();
        }

        private void ZapocniUnositiPodatke()
        {
            txtKorisnickoIme.Focus();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPrikaziLozinku.Checked == true)
            {
                txtLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                txtLozinka.UseSystemPasswordChar = true;
            }
        }
    }
}
