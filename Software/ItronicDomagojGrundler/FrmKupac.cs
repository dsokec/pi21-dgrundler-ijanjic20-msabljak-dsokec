using ItronicClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itronic
{
    /// <summary>
    /// Autor: Domagoj Grundler
    /// </summary>
    public partial class FrmKupac : Form
    {
        private Entities context;
        public Kupac PovratniKupac;
        public FrmKupac()
        {
            InitializeComponent();
        }

        private void FrmKupac_Load(object sender, EventArgs e)
        {
            context = new Entities();
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string brMobitel = txtBrojMobitela.Text;
            string email = txtEmail.Text;
            string adresa = txtAdresa.Text;
            string grad = txtGrad.Text;

            PovratniKupac = Repository.DodajKupca(ime, prezime, brMobitel, email, adresa, grad);
            Close();
        }

        private void tsmiItronicManual_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://E:\\FOI\\10.semestar(smh)\\PI\\projekt\\chm\\ItronicHelp.chm");
        }
    }
}
