﻿using System;
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
using ClassLibrary2.Klase;

namespace ItronicStore
{
    public partial class Izbornik : Form
    {
        private wfLogin Login;
        private NovaReklamacija Reklamacija;
        private KorisnickaRecenzija Recenzija;
        private PovratnaInformacija PovratnaInformacija;
        wfLogin wfLogin;

        private string korisnickoImeLogina;

        internal void PostaviPrethodnuFormu(wfLogin x)
        {
            wfLogin = x;
        }

        //public Izbornik(wfLogin login, string korisnickoIme)
        public Izbornik(wfLogin login, string korisnickoIme)
        {
            InitializeComponent();
            this.Login = login;
            this.korisnickoImeLogina = korisnickoIme;

            Login.Hide();
        }

        private void btnRecenzija_Click(object sender, EventArgs e)
        {
            if (Recenzija == null)
            {
                Recenzija = new KorisnickaRecenzija(this, korisnickoImeLogina);
                Recenzija.FormClosed += Recenzija_FormClosed;
            }
            Recenzija.Show(this);
            Hide();
        }

        private void Recenzija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Recenzija = null;
            Show();
        }

        private void btnReklamacija_Click(object sender, EventArgs e)
        {
            if (Reklamacija == null)
            {
                Reklamacija = new NovaReklamacija(this,korisnickoImeLogina);
                Reklamacija.FormClosed += Reklamacija_FormClosed;
            }

            Reklamacija.Show(this);
            Hide();
        }

        private void Reklamacija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reklamacija = null;
            Show();
        }

        // Natrag
        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            //korisnickoImeLogina = null;
            //izbornik = null;
            //korisnickoImeLogina = null;
            Hide();
        }

        private void Izbornik_Load(object sender, EventArgs e)
        {
            lblViStePrijavljeniKao.Text = korisnickoImeLogina;

        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            if (PovratnaInformacija == null)
            {
                PovratnaInformacija = new PovratnaInformacija(korisnickoImeLogina);
                PovratnaInformacija.FormClosed += PovratnaInformacija_FormClosed;
            }

            PovratnaInformacija.Show(this);
            Hide();
        }

        private void PovratnaInformacija_FormClosed(object sender, FormClosedEventArgs e)
        {
            PovratnaInformacija = null;
            Show();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void Izbornik_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OtvoriHelpFile(1030);
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
