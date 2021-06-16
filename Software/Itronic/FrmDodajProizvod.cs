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
    /// <summary>
    /// Autor: Domagoj Grundler
    /// </summary>
    public partial class FrmDodajProizvod : Form
    {
        public FrmDodajProizvod()
        {
            InitializeComponent();
        }

        private void FrmDodajProizvod_Load(object sender, EventArgs e)
        {
            PopuniKategorije();
        }

        private void PopuniKategorije()
        {
            cmbKategorija.DataSource = Repository.DohvatiSveKategorije();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = cmbKategorija.SelectedItem as Kategorija;
            string naziv = txtNaziv.Text;
            float prodajnaCijena = float.Parse(txtProdajnaCijena.Text);
            float kupovnaCijena = float.Parse(txtKupovnaCijena.Text);
            string opis = rtxtOpis.Text;

            Repository.DodajProizvod(kategorija, naziv, prodajnaCijena, kupovnaCijena, opis);
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
