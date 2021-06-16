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
    public partial class FrmPrimka : Form
    {
        private DataTable kosarica;
        public double ukupnaCijena;
        private Proizvod odabraniProizvod;
        private List<Proizvod> odabraniProizvodi;
        private List<int> kolicine;
        public FrmPrimka()
        {
            InitializeComponent();
            InicijalizirajKosaricu();
            ukupnaCijena = 0;
            odabraniProizvodi = new List<Proizvod>();
            kolicine = new List<int>();
        }

        private void InicijalizirajKosaricu()
        {
            kosarica = new DataTable();
            kosarica.Columns.Add("Naziv", typeof(string));
            kosarica.Columns.Add("Cijena", typeof(float));
            kosarica.Columns.Add("Kolicina", typeof(int));
            kosarica.Columns.Add("Iznos", typeof(float));
        }

        private void FrmPrimka_Load(object sender, EventArgs e)
        {
            PrikaziProizvodeIKosaricu();
            PopuniKategorije();
        }

        private void PopuniKategorije()
        {
            cmbKategorija.DataSource = Repository.DohvatiSveKategorije();
        }

        private void PrikaziProizvodeIKosaricu()
        {
            dgvKatalog.DataSource = null;
            dgvKatalog.DataSource = Repository.DohvatiSveProizvode();
            dgvKatalog.Columns["Kategorija"].Visible = false;
            dgvKatalog.Columns["Recenzijas"].Visible = false;
            dgvKatalog.Columns["Reklamacijas"].Visible = false;
            dgvKatalog.Columns["StavkaPrimkes"].Visible = false;
            dgvKatalog.Columns["StavkaRacunas"].Visible = false;
            dgvKatalog.Columns["ID"].Visible = false;
            dgvKatalog.Columns["KategorijaID"].Visible = false;
            dgvKatalog.Columns["ProdajnaCijena"].Visible = false;

            dgvPrimka.DataSource = null;
            dgvPrimka.DataSource = kosarica;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (odabraniProizvod == null)
            {
                MessageBox.Show("Morate prvo odabrati proizvod!");
                return;
            }
            DodajUKosaricu();
        }

        private void DodajUKosaricu()
        {
            string naziv = odabraniProizvod.Naziv;
            double cijena = odabraniProizvod.KupovnaCIjena;
            if (txtKolicina.Text == "")
            {
                MessageBox.Show("Morate unijeti količinu!");
                return;
            }
            int kolicina = int.Parse(txtKolicina.Text);
            double iznos = cijena * kolicina;

            if (odabraniProizvodi.Contains(odabraniProizvod))
            {
                int index = odabraniProizvodi.IndexOf(odabraniProizvod);
                kolicina += kolicine[index];
                kolicine[index] = kolicina;
                iznos = cijena * kolicina;
                kosarica.Rows.RemoveAt(index);
                kosarica.Rows.Add(naziv, cijena, kolicina, iznos);
                AzurirajKosaricu(iznos);
            }
            else
            {
                odabraniProizvodi.Add(odabraniProizvod);
                kolicine.Add(kolicina);

                kosarica.Rows.Add(naziv, cijena, kolicina, iznos);
                AzurirajKosaricu(iznos);
            }
        }

        private void AzurirajKosaricu(double iznos)
        {
            dgvPrimka.DataSource = null;
            dgvPrimka.DataSource = kosarica;

            ukupnaCijena += iznos;
            lblUkupnaCijenaIznos.Text = ukupnaCijena.ToString();
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            if (odabraniProizvodi.Count == 0 || kolicine.Count == 0)
            {
                MessageBox.Show("Niste stavili niti jedan proizvod u Vašu košaricu!");
                return;
            }
            Repository.PosaljiNarudzbenicu(odabraniProizvodi, kolicine);
            Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = cmbKategorija.SelectedItem as Kategorija;
            dgvKatalog.DataSource = null;
            dgvKatalog.DataSource = Repository.DohvatiProizvodePoKategoriji(kategorija);
        }

        private void btnMakniFiltriranje_Click(object sender, EventArgs e)
        {
            dgvKatalog.DataSource = null;
            dgvKatalog.DataSource = Repository.DohvatiSveProizvode();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvKatalog_SelectionChanged(object sender, EventArgs e)
        {
            odabraniProizvod = dgvKatalog.CurrentRow.DataBoundItem as Proizvod;
        }
    }
}
