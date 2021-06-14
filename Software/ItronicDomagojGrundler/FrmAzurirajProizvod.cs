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
    public partial class FrmAzurirajProizvod : Form
    {
        private Proizvod odabraniProizvod;
        public FrmAzurirajProizvod(Proizvod proizvod)
        {
            InitializeComponent();
            odabraniProizvod = proizvod;
        }

        private void FrmAzurirajProizvod_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            PopuniKategorije();
            txtNaziv.Text = odabraniProizvod.Naziv;
            txtProdajnaCijena.Text = odabraniProizvod.ProdajnaCijena.ToString();
            txtKupovnaCijena.Text = odabraniProizvod.KupovnaCIjena.ToString();
            rtxtOpis.Text = odabraniProizvod.Opis;
        }

        private void PopuniKategorije()
        {
            List<Kategorija> kategorije = Repository.DohvatiSveKategorije();
            cbKategorija.DataSource = kategorije;

            for (int i = 0; i < cbKategorija.Items.Count; i++)
            {
                if ((cbKategorija.Items[i] as Kategorija).ID == odabraniProizvod.KategorijaID)
                {
                    cbKategorija.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnAzurirajProizvod_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = cbKategorija.SelectedItem as Kategorija;
            string naziv = txtNaziv.Text;
            float prodajnaCijena = float.Parse(txtProdajnaCijena.Text);
            float kupovnaCijena = float.Parse(txtKupovnaCijena.Text);
            string opis = rtxtOpis.Text;

            Repository.AzurirajProizvod(odabraniProizvod, kategorija, naziv, prodajnaCijena, kupovnaCijena, opis);
            Close();
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
