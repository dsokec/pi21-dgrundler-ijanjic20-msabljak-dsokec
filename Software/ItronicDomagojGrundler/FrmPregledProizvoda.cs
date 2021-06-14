using ItronicClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itronic
{
    /// <summary>
    /// Autor: Domagoj Grundler
    /// </summary>
    public partial class FrmPregledProizvoda : Form
    {
        public FrmPregledProizvoda()
        {
            InitializeComponent();
        }

        private void FrmPregledProizvoda_Load(object sender, EventArgs e)
        {
            PrikaziProizvode();
            PopuniKategorije();
        }

        private void PopuniKategorije()
        {
            cmbKategorija.DataSource = null;
            cmbKategorija.DataSource = Repository.DohvatiSveKategorije();
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
        }
        

        private void btnKupovina_Click(object sender, EventArgs e)
        {
            FrmProdaja form = new FrmProdaja();
            form.ShowDialog();
            PrikaziProizvode();
        }

        private void btnDodajAzuriraj_Click(object sender, EventArgs e)
        {
            FrmDodajProizvod form = new FrmDodajProizvod();
            form.ShowDialog();
            PrikaziProizvode();
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            FrmNarudzbenica form = new FrmNarudzbenica();
            form.ShowDialog();
            PrikaziProizvode();
        }
        /// <summary>
        /// Ne radi u većini slučajeva zbog postavki unutar baze podataka koje sam zaboravio izmjeniti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Proizvod odabraniProizvod = dgvProizvodi.CurrentRow.DataBoundItem as Proizvod;
            Repository.ObrisiProizvod(odabraniProizvod);
            PrikaziProizvode();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Proizvod odabraniProizvod = dgvProizvodi.CurrentRow.DataBoundItem as Proizvod;
            FrmAzurirajProizvod form = new FrmAzurirajProizvod(odabraniProizvod);
            form.ShowDialog();
            PrikaziProizvode();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Kategorija odabranaKategorija = cmbKategorija.SelectedItem as Kategorija;
            dgvProizvodi.DataSource = null;
            dgvProizvodi.DataSource = Repository.DohvatiProizvodePoKategoriji(odabranaKategorija);
        }

        private void btnMakniFiltriranje_Click(object sender, EventArgs e)
        {
            dgvProizvodi.DataSource = null;
            dgvProizvodi.DataSource = Repository.DohvatiSveProizvode();
        }

        private void itronicManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://E:\\FOI\\10.semestar(smh)\\PI\\projekt\\chm\\ItronicHelp.chm");
        }
    }
}
