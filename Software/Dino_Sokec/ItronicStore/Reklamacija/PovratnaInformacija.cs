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
    public partial class PovratnaInformacija : Form
    {
        private string korisnickoIme;
        public PovratnaInformacija(string korisnik)
        {
            InitializeComponent();
            this.korisnickoIme = korisnik;
            
        }

        // button Natrag
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void PovratnaInformacija_Load(object sender, EventArgs e)
        {
            UcitajDGV(korisnickoIme);
        }

        private void UcitajDGV(string korisnickoIme)
        {
            dgvPovratneInformacije.DataSource = null;
            dgvPovratneInformacije.DataSource = TOOL_Odgovor.DohvatiSvePovratneOdgovoreKorisnik(korisnickoIme);

            lblBrojRedaka.Text = dgvPovratneInformacije.Rows.Count.ToString();
        }

        private void PovratnaInformacija_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OtvoriHelpFile(1090);
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
