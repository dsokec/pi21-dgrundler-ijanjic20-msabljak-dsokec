using ItronicClassLibrary;
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
    public partial class FrmKupac : Form
    {
        public Kupac PovratniKupac;
        public FrmKupac()
        {
            InitializeComponent();
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
    }
}
