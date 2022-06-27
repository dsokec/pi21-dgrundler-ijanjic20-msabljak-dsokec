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

namespace ItronicStore
{
    public partial class IzbornikAdmin : Form
    {
        private DolazneReklamacije dolazneReklamacije;
        private AdminPrijava adminPrijava;
        private GrafickiPrikaz grafickiPrikaz;
        private string korisnickoImeAdmina;
        public IzbornikAdmin(AdminPrijava admin, string korisnickoImeAdmina)
        {
            InitializeComponent();
            this.adminPrijava = admin;
            this.korisnickoImeAdmina = korisnickoImeAdmina;
            adminPrijava.Hide();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {

            if(dolazneReklamacije == null)
            {
                dolazneReklamacije = new DolazneReklamacije(korisnickoImeAdmina);
                dolazneReklamacije.FormClosed += DolazneReklamacije_FormClosed;
            }
            dolazneReklamacije.Show(this);
            Hide();
        }

        private void DolazneReklamacije_FormClosed(object sender, FormClosedEventArgs e)
        {
            dolazneReklamacije = null;
            Show();
        }

        private void btnGrafickiPrikaz_Click(object sender, EventArgs e)
        {
            if(grafickiPrikaz == null)
            {
                grafickiPrikaz = new GrafickiPrikaz();
                grafickiPrikaz.FormClosed += GrafickiPrikaz_FormClosed;
            }
            grafickiPrikaz.Show(this);
            Hide();
        }

        private void GrafickiPrikaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            grafickiPrikaz = null;
            Show();
        }

        private void IzbornikAdmin_Load(object sender, EventArgs e)
        {
            this.Refresh();
            NapisiNazivPrijavljenogAdmina();
        }

        private void NapisiNazivPrijavljenogAdmina()
        {
            lblPrijavljeniKao.Text = string.Empty;
            lblPrijavljeniKao.Text = string.Format($"Vi ste prijavljeni kao {korisnickoImeAdmina}");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Refresh();
            Hide();
        }

        private void IzbornikAdmin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OtvoriHelpFile(1040);
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
