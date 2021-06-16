using ItronicClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            dgvKatalog.Columns["Kategorija"].Visible = false;
            dgvKatalog.Columns["Recenzijas"].Visible = false;
            dgvKatalog.Columns["Reklamacijas"].Visible = false;
            dgvKatalog.Columns["StavkaPrimkes"].Visible = false;
            dgvKatalog.Columns["StavkaRacunas"].Visible = false;
            dgvKatalog.Columns["ID"].Visible = false;
            dgvKatalog.Columns["KategorijaID"].Visible = false;
        }

        private void btnMakniFiltriranje_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Kod preuzet sa: https://helpcreator.net/en/index.php/2019/01/01/context-sensitive-help-in-c-and-chm-files/
        /// </summary>
        /// <param name="id"></param>
        private void OpenHelp(int id = -1)
        {
            String help = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            if (id == -1)
            {
                //open help with default settings (do not jump to topic)
                System.Diagnostics.Process.Start(help);
            }
            else
            {
                //jump to topic
                Help.ShowHelp(this, help, HelpNavigator.TopicId, id.ToString());
            }
        }

        private void FrmPregledProizvoda_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OpenHelp();
        }
    }
}
