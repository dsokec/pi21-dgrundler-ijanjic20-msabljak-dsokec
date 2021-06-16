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
            dgvKatalog.DataSource = null;
            dgvKatalog.DataSource = Repository.DohvatiSveProizvode();
            dgvKatalog.Columns["Kategorija"].Visible = false;
            dgvKatalog.Columns["Recenzijas"].Visible = false;
            dgvKatalog.Columns["Reklamacijas"].Visible = false;
            dgvKatalog.Columns["StavkaPrimkes"].Visible = false;
            dgvKatalog.Columns["StavkaRacunas"].Visible = false;
            dgvKatalog.Columns["ID"].Visible = false;
            dgvKatalog.Columns["KategorijaID"].Visible = false;
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Kategorija odabranaKategorija = cmbKategorija.SelectedItem as Kategorija;
            dgvKatalog.DataSource = null;
            dgvKatalog.DataSource = Repository.DohvatiProizvodePoKategoriji(odabranaKategorija);
        }

        private void btnMakniFiltriranje_Click(object sender, EventArgs e)
        {
            dgvKatalog.DataSource = null;
            dgvKatalog.DataSource = Repository.DohvatiSveProizvode();
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            FrmDodajProizvod form = new FrmDodajProizvod();
            form.ShowDialog();
            PrikaziProizvode();
        }

        private void btnAzurirajProizvod_Click(object sender, EventArgs e)
        {
            Proizvod odabraniProizvod;
            try
            {
                odabraniProizvod = VratiProizvod();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Niste odabrali proizvod!");
                return;
            }
            
            FrmAzurirajProizvod form = new FrmAzurirajProizvod(odabraniProizvod);
            form.ShowDialog();
            PrikaziProizvode();
        }

        private void btnObrisiProizvod_Click(object sender, EventArgs e)
        {
            Proizvod odabraniProizvod;
            try
            {
                odabraniProizvod = VratiProizvod();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Niste odabrali proizvod!");
                return;
            }
            Repository.ObrisiProizvod(odabraniProizvod);
            PrikaziProizvode();
        }

        private void btnTrgovina_Click(object sender, EventArgs e)
        {
            FrmProdaja form = new FrmProdaja();
            form.ShowDialog();
            PrikaziProizvode();
        }

        private void btnNabaviRobu_Click(object sender, EventArgs e)
        {
            FrmPrimka form = new FrmPrimka();
            form.ShowDialog();
            PrikaziProizvode();
        }

        private Proizvod VratiProizvod()
        {
            Proizvod proizvod = dgvKatalog.CurrentRow.DataBoundItem as Proizvod;
            return proizvod;
        }
    }
}
