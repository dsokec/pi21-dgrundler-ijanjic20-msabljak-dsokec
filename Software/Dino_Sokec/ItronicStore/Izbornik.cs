﻿using System;
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
    public partial class Izbornik : Form
    {
        private string korisnickoImeLogina;
        wfLogin wfLogin;

        internal void PostaviPrethodnuFormu(wfLogin x)
        {
            wfLogin = x;
        }

        public Izbornik()
        {
            InitializeComponent();
        }

        public Izbornik(string korisnickoIme)
        {
            InitializeComponent();
            this.korisnickoImeLogina = korisnickoIme;
        }

        private void btnRecenzija_Click(object sender, EventArgs e)
        {
            var forma2 = new KorisnickaRecenzija(korisnickoImeLogina);
            forma2.PostaviPrethodnuFormu(this);
            forma2.Show();
            this.Hide();

            //this.Hide();
            //var form2 = new KorisnickaRecenzija(korisnickoImeLogina);
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();


        }

        private void btnReklamacija_Click(object sender, EventArgs e)
        {
            NovaReklamacija nova = new NovaReklamacija();
            nova.Show();
            this.Hide();
        }

        // Natrag
        private void button2_Click(object sender, EventArgs e)
        {
            wfLogin.Show();
            this.Dispose();
        }
    }
}
