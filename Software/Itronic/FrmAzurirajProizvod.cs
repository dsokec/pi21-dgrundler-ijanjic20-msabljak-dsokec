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
            cmbKategorija.DataSource = Repository.DohvatiSveKategorije();
            OdaberiKategoriju();
        }

        private void OdaberiKategoriju()
        {
            for (int i = 0; i < cmbKategorija.Items.Count; i++)
            {
                if ((cmbKategorija.Items[i] as Kategorija).ID == odabraniProizvod.KategorijaID)
                {
                    cmbKategorija.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = cmbKategorija.SelectedItem as Kategorija;
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
    }
}
