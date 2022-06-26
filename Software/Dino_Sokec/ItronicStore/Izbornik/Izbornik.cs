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
    public partial class Izbornik : Form
    {
        private wfLogin Login;
        private NovaReklamacija Reklamacija;
        private KorisnickaRecenzija Recenzija;
        private PovratnaInformacija PovratnaInformacija;
        //private Izbornik izbornik;


        private string korisnickoImeLogina = null;
        wfLogin wfLogin;

        internal void PostaviPrethodnuFormu(wfLogin x)
        {
            wfLogin = x;
        }

        public Izbornik(wfLogin login, string korisnickoIme)
        {
            InitializeComponent();
            this.Login = login;
            //this.korisnickoImeLogina = null;
            this.korisnickoImeLogina = korisnickoIme;
            Login.Hide();
        }

        public Izbornik(string korisnickoIme)
        {
            InitializeComponent();
            this.korisnickoImeLogina = korisnickoIme;
        }

        private void btnRecenzija_Click(object sender, EventArgs e)
        {
            if (Recenzija == null)
            {
                Recenzija = new KorisnickaRecenzija(this, korisnickoImeLogina);
                Recenzija.FormClosed += Recenzija_FormClosed;
            }
            //this.Invalidate();
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
                Reklamacija = new NovaReklamacija(korisnickoImeLogina);
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
            this.Invalidate();
            //this.Refresh();
            Napisi_Naziv_Prijavljenog_Korisnika();
        }

        private void Napisi_Naziv_Prijavljenog_Korisnika()
        {
            lblViStePrijavljeniKao.Text = korisnickoImeLogina;
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            if (PovratnaInformacija == null)
            {
                PovratnaInformacija = new PovratnaInformacija();
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
    }
}
