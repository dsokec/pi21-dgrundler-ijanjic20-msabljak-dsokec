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
    public partial class FrmNarudzbenica : Form
    {
        private DataTable prikaz;
        double ukupnaCijena;
        private List<Proizvod> odabraniProizvodi;
        private List<int> kolicine;
        public FrmNarudzbenica()
        {
            InitializeComponent();
            prikaz = new DataTable();
            prikaz.Columns.Add("Naziv", typeof(string));
            prikaz.Columns.Add("Cijena", typeof(float));
            prikaz.Columns.Add("Kolicina", typeof(int));
            prikaz.Columns.Add("Iznos", typeof(float));
            ukupnaCijena = 0;
            odabraniProizvodi = new List<Proizvod>();
            kolicine = new List<int>();
        }

        private void FrmNarudzbenica_Load(object sender, EventArgs e)
        {
            PrikaziProizvode();
            PopuniKategorije();
        }

        private void PopuniKategorije()
        {
            cbKategorija.DataSource = Repository.DohvatiSveKategorije();
        }

        private void PrikaziProizvode()
        {
            dgvProizvodi.DataSource = null;
            dgvProizvodi.DataSource = Repository.DohvatiSveProizvode();
            dgvProizvodi.Columns["Kategorija"].Visible = false;
            dgvProizvodi.Columns["Recenzijas"].Visible = false;
            dgvProizvodi.Columns["Reklamacijas"].Visible = false;
            dgvProizvodi.Columns["StavkaPrimkes"].Visible = false;
            dgvProizvodi.Columns["StavkaRacunas"].Visible = false;
            dgvProizvodi.Columns["ID"].Visible = false;
            dgvProizvodi.Columns["KategorijaID"].Visible = false;
            dgvProizvodi.Columns["ProdajnaCijena"].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Proizvod odabraniProizvod = dgvProizvodi.CurrentRow.DataBoundItem as Proizvod;
            string naziv = odabraniProizvod.Naziv;
            double cijena = odabraniProizvod.KupovnaCIjena;
            if (txtKolicina.Text == "")
            {
                MessageBox.Show("Morate unijeti količinu!");
                return;
            }
            int kolicina = int.Parse(txtKolicina.Text);
            double iznos = cijena * kolicina;
            prikaz.Rows.Add(naziv, cijena, kolicina, iznos);
            dgvNarudzbenica.DataSource = prikaz;
            odabraniProizvodi.Add(odabraniProizvod);
            kolicine.Add(kolicina);
            ukupnaCijena += iznos;
            lblUkupnaCijenaIznos.Text = ukupnaCijena.ToString();
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            Primka novaPrimka = Repository.DodajPrimku();

            for (int i = 0; i < odabraniProizvodi.Count; i++)
            {
                Proizvod proizvodZaDodaju = odabraniProizvodi[i];
                int kolicinaZaDodaju = kolicine[i];

                Repository.DodajStavkuPrimke(novaPrimka, proizvodZaDodaju, kolicinaZaDodaju);
            }
            Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = cbKategorija.SelectedItem as Kategorija;
            dgvProizvodi.DataSource = null;
            dgvProizvodi.DataSource = Repository.DohvatiProizvodePoKategoriji(kategorija);
        }

        private void btnMakniFiltriranje_Click(object sender, EventArgs e)
        {
            dgvProizvodi.DataSource = null;
            dgvProizvodi.DataSource = Repository.DohvatiSveProizvode();
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
