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
    public partial class FrmProdaja : Form
    {
        /* 
        kosarica - tablica koja služi za prikaz onih podataka koji su od većeg interesa kupcu
        ukupnaCijena - ukupna cijena narudžbe
        odabraniProizvod - proizvod koji je selektiran na katalogu.
        odabraniProizvodi - lista tipa 'Proizvod' u koju se dodaju proizvodi koje kupac želi naručiti
        kolicine - lista tipa 'int' u koju se dodaju željene količine proizvoda koje se želi naručiti
        trenutniKupac - kupac koji odrađuje narudžbu
        */
        private DataTable kosarica;
        double ukupnaCijena;
        private Proizvod odabraniProizvod;
        private List<Proizvod> odabraniProizvodi;
        private List<int> kolicine;
        private Kupac trenutniKupac;
        public FrmProdaja()
        {
            InitializeComponent();
            InicijalizirajKosaricu();
            ukupnaCijena = 0;
            odabraniProizvodi = new List<Proizvod>();
            kolicine = new List<int>();
        }

        /// <summary>
        /// Kreiranje novog objekta tipa DataTable, koji ce sluziti za prikaz traženih proizvoda
        /// </summary>
        private void InicijalizirajKosaricu()
        {
            kosarica = new DataTable();
            kosarica.Columns.Add("Naziv", typeof(string));
            kosarica.Columns.Add("Cijena", typeof(double));
            kosarica.Columns.Add("Kolicina", typeof(int));
            kosarica.Columns.Add("Iznos", typeof(double));
        }

        private void FrmProdaja_Load(object sender, EventArgs e)
        {
            PrikaziProizvodeIKosaricu();
            PopuniKategorije();
        }

        private void PopuniKategorije()
        {
            cbKategorija.DataSource = Repository.DohvatiSveKategorije();
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
            dgvKatalog.Columns["KupovnaCijena"].Visible = false;

            dgvKosarica.DataSource = null;
            dgvKosarica.DataSource = kosarica;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (odabraniProizvod == null)
            {
                MessageBox.Show("Morate prvo odabrati proizvod!");
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
            else if (int.Parse(txtKolicina.Text) > odabraniProizvod.Kolicina)
            {
                MessageBox.Show("Nemamo toliko traženog proizvoda! Molimo Vas da upišete manju količinu.");
                return;
            }
            int kolicina = int.Parse(txtKolicina.Text);
            double iznos = cijena * kolicina;

            /* Ako se odabrani proizvod nalazi na listi, povećava mu se količina, inače se dodaje u popis odabraniProizvodi*/
            if (odabraniProizvodi.Contains(odabraniProizvod))
            {
                int index = odabraniProizvodi.IndexOf(odabraniProizvod);
                kolicina += kolicine[index];
                kolicine[index] = kolicina;
                if (kolicina > odabraniProizvod.Kolicina)
                {
                    MessageBox.Show("Ne možete naručiti veću količinu proizvoda od one koja se nalazi u zalihi!");
                    return;
                }
                iznos = cijena * kolicina;
                kosarica.Rows.RemoveAt(index);
                kosarica.Rows.Add(naziv, cijena, kolicina, iznos);
            }
            else
            {
                odabraniProizvodi.Add(odabraniProizvod);
                kolicine.Add(kolicina);
                kosarica.Rows.Add(naziv, cijena, kolicina, iznos);
            }
            AzurirajKosaricu(iznos);
        }

        private void AzurirajKosaricu(double iznos)
        {
            dgvKosarica.DataSource = null;
            dgvKosarica.DataSource = kosarica;

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
            using (FrmKupac form = new FrmKupac())
            {
                form.ShowDialog();
                trenutniKupac = form.PovratniKupac;
            }

            Repository.PosaljiNarudzbu(odabraniProizvodi, kolicine, trenutniKupac);
            Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = cbKategorija.SelectedItem as Kategorija;
            dgvKatalog.DataSource = Repository.DohvatiProizvodePoKategoriji(kategorija);
            dgvKatalog.Columns["Kategorija"].Visible = false;
            dgvKatalog.Columns["Recenzijas"].Visible = false;
            dgvKatalog.Columns["Reklamacijas"].Visible = false;
            dgvKatalog.Columns["StavkaPrimkes"].Visible = false;
            dgvKatalog.Columns["StavkaRacunas"].Visible = false;
            dgvKatalog.Columns["ID"].Visible = false;
            dgvKatalog.Columns["KategorijaID"].Visible = false;
            dgvKatalog.Columns["KupovnaCijena"].Visible = false;
        }

        private void btnMakniFiltriranje_Click(object sender, EventArgs e)
        {
            dgvKatalog.DataSource = Repository.DohvatiSveProizvode();
            dgvKatalog.Columns["Kategorija"].Visible = false;
            dgvKatalog.Columns["Recenzijas"].Visible = false;
            dgvKatalog.Columns["Reklamacijas"].Visible = false;
            dgvKatalog.Columns["StavkaPrimkes"].Visible = false;
            dgvKatalog.Columns["StavkaRacunas"].Visible = false;
            dgvKatalog.Columns["ID"].Visible = false;
            dgvKatalog.Columns["KategorijaID"].Visible = false;
            dgvKatalog.Columns["KupovnaCijena"].Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProizvodi_SelectionChanged(object sender, EventArgs e)
        {
            odabraniProizvod = dgvKatalog.CurrentRow.DataBoundItem as Proizvod;
        }
    }
}
