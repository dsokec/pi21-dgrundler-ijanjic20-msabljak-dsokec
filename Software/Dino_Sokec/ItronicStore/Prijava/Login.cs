﻿using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using ClassLibrary2.ToolBox;
using System.Data.Entity;
using ClassLibrary2.Klase;

namespace ItronicStore
{
    public partial class wfLogin : Form
    {
        private Izbornik Izbornik = null;
        private AdminPrijava adminPrijava;
        
        public wfLogin()
        {
            InitializeComponent();
        }

        public wfLogin(Izbornik izbornik)
        {
            //this.Izbornik = null;
            this.Izbornik = izbornik;
            Izbornik.Hide();
        }

        // Gumb prijavi se - ulazak u Izbornik
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            //cmbKorisnickoIme.Refresh();
            //string korisnickoIme = null;
            //KorisnickoImeKorisnika.KorisnickoIme = TOOL_Korisnik.DohvatiKorisnickoImeKorisnika(cmbKorisnickoIme.Text);
            string korisnickoIme = TOOL_Korisnik.DohvatiKorisnickoImeKorisnika(cmbKorisnickoIme.Text);

            if (Izbornik == null)
            {
                Izbornik = new Izbornik(this, korisnickoIme);
                Izbornik.FormClosed += Izbornik_FormClosed;
            }

            //this.Refresh();
            Izbornik.Show(this);
            Hide();
        }

        private void Izbornik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Izbornik = null;
            Show();
        }

        private string DohvatiKorisnickoImeIzPadajuceListe()
        {
            string korisnickoIme = cmbKorisnickoIme.Text;
            return korisnickoIme;
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
            //this.Invalidate();
            //this.Refresh();
            NapuniCombobox();
        }

        private void NapuniCombobox()
        {
            cmbKorisnickoIme.DataSource = null;
            cmbKorisnickoIme.DataSource = TOOL_Korisnik.DohvatiSveKorisnike();
            cmbKorisnickoIme.SelectedIndex = 0;
            txtLozinkaLogin.ReadOnly = true;
        }

        private void cmbKorisnickoIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string korisnickoIme = cmbKorisnickoIme.SelectedItem.ToString();
            txtLozinkaLogin.Text = TOOL_Korisnik.DohvatiLozinkuZaOdabranogKorisnika(korisnickoIme);
            txtLozinkaLogin.PasswordChar = '*';
        }

        private void btnPrijavaAdmin_Click(object sender, EventArgs e)
        {
            if (adminPrijava == null)
            {
                adminPrijava = new AdminPrijava(this);
                adminPrijava.FormClosed += AdminPrijava_FormClosed;
            }
            adminPrijava.Show(this);
            Hide();
        }

        private void AdminPrijava_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminPrijava = null;
            Show();
        }
    }
}
