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
    public partial class IzbornikAdmin : Form
    {
        private string korisnickoImeAdmina;
        private DolazneReklamacije dolazneReklamacije;
        private AdminPrijava adminPrijava;
        public IzbornikAdmin(AdminPrijava admin)
        {
            InitializeComponent();
            this.adminPrijava = admin;
            adminPrijava.Hide();
        }
        public IzbornikAdmin(string admin)
        {
            InitializeComponent();
            this.korisnickoImeAdmina = admin;
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            //DolazneReklamacije dolazne = new DolazneReklamacije();
            //dolazne.Show();
            //this.Hide();

            if(dolazneReklamacije == null)
            {
                dolazneReklamacije = new DolazneReklamacije();
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
            GrafickiPrikaz grafickiPrikaz = new GrafickiPrikaz();
            grafickiPrikaz.Show();
            this.Hide();
        }

        private void IzbornikAdmin_Load(object sender, EventArgs e)
        {
            NapisiNazivPrijavljenogAdmina();
        }

        private void NapisiNazivPrijavljenogAdmina()
        {
            //lblPrijavljeniKao.Text = string.Format($"Vi ste prijavljeni kao {}");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }
    }
}
