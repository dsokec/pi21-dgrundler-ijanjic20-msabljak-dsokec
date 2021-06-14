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
    public partial class FrmDodajProizvod : Form
    {
        
        public FrmDodajProizvod()
        {
            InitializeComponent();
        }

        private void FrmDodajProizvod_Load(object sender, EventArgs e)
        {
            FillCategories();
        }

        private void FillCategories()
        {
            cbKategorija.DataSource = Repository.DohvatiSveKategorije();
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = cbKategorija.SelectedItem as Kategorija;
            string naziv = txtNaziv.Text;
            float prodajnaCijena = float.Parse(txtProdajnaCijena.Text);
            float kupovnaCijena = float.Parse(txtKupovnaCijena.Text);
            string opis = rtxtOpis.Text;

            Repository.DodajProizvod(kategorija, naziv, prodajnaCijena, kupovnaCijena, opis);
            Close();
        }

        private void FrmDodajProizvod_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiItronicManual_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://E:\\FOI\\10.semestar(smh)\\PI\\projekt\\chm\\ItronicHelp.chm");
        }
    }
}
