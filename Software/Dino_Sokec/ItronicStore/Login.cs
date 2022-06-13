using KlasaUpravljanja;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
        }

        private void NapuniCombobox()
        {

            using (var db = new Entiteti())
            {
                var upit = from x in db.Korisnik
                           select x.KorisnickoIme;

                cmbKorisnickoIme.DataSource = upit.ToList();
                cmbKorisnickoIme.SelectedIndex = 0;
            }
        }

        private void cmbKorisnickoIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabir = cmbKorisnickoIme.SelectedItem.ToString();
            using (var db = new Entiteti())
            {
                var upit = from x in db.Korisnik
                           where x.KorisnickoIme.ToString() == odabir
                           select x.Lozinka;
                cmbLozinka.DataSource = upit.ToList();
            }
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
