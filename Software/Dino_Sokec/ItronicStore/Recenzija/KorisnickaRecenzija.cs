using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary2.ToolBox;
using ClassLibrary2.Klase;
using ClassLibrary2;
using TOOL_Korisnik = ClassLibrary2.ToolBox.TOOL_Korisnik;
using TOOL_Recenzija = ClassLibrary2.ToolBox.TOOL_Recenzija;
using TOOL_Proizvod = ClassLibrary2.ToolBox.TOOL_Proizvod;
using ClassLibrary2.Iznimke;

namespace ItronicStore
{
    public partial class KorisnickaRecenzija : Form
    {
        private string korisnickoIme;
        //Izbornik izbornik;
        private Izbornik izbornik;
        
        // Prethodna WinForma + 2 konstruktora
        internal void PostaviPrethodnuFormu(Izbornik x)
        {
            izbornik = x;
        }

        public KorisnickaRecenzija()
        {
            InitializeComponent(); 
        }

        public KorisnickaRecenzija(Izbornik izbornik, string korisnickoImeLogina)
        {
            InitializeComponent();
            this.izbornik = izbornik;
            this.korisnickoIme = korisnickoImeLogina;
            izbornik.Hide();
        }

        private void KorisnickaRecenzija_Load(object sender, EventArgs e)
        {
            UcitajWindowsFormuKorisnickaRecenzija();
        }

        private void UcitajWindowsFormuKorisnickaRecenzija()
        {
            NapuniDGVProizvodima(korisnickoIme);

            Namjesti_CMB_Filtar();

            NapuniPovijestRecenzijaKorisnika(korisnickoIme);

            NapuniTekstualniOkvirKorisnika(korisnickoIme);

            NapuniTekstualniOkvirProizvod();

            Namjesti_RadioButton();

            OnemoguciButtonAzuriraj();
        }

        private void NapuniTekstualniOkvirProizvod()
        {
            txtPronadjeniProizvod.Text = dgvPopisProizvoda.Rows[0].Cells[0].Value.ToString();
        }

        // Namjestanje toolboxa
        private void Namjesti_RadioButton()
        {
            radioB5.Checked = true;
        }

        private void Namjesti_CMB_Filtar()
        {
            comboBox1.SelectedIndex = 0;
        }

        // Punjenje DGV-a (x2) i textBoxova
        private void NapuniTekstualniOkvirKorisnika(string korisnickoIme)
        {
            txtKorisnickoIme.Text = korisnickoIme;
            txtIme.Text = TOOL_Korisnik.DohvatiImeKorisnika(korisnickoIme);
            txtPrezime.Text = TOOL_Korisnik.DohvatiPrezimeKorisnika(korisnickoIme);
        }

        private void NapuniPovijestRecenzijaKorisnika(string korisnickoIme)
        {
            
            dgvPovijestRecenzija.DataSource = null;
            dgvPovijestRecenzija.DataSource = TOOL_Recenzija.NapuniPovijestRecenzijaKorisnika(korisnickoIme);

            dgvPovijestRecenzija.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPovijestRecenzija.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblBrojRedakaPovijest.Text = dgvPovijestRecenzija.Rows.Count.ToString();

        }

        private void NapuniDGVProizvodima(string korisnickoIme)
        {
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Proizvod.DohvatiSveDostupneProizvodeZaKorisnika(korisnickoIme);

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPopisProizvoda.RowsAdded += RowsAdded;
            dgvPopisProizvoda.RowsRemoved += RowsRemoved;

        }

        // Rows Removed and Added
        private void RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblBrojRedaka.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        private void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblBrojRedaka.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        // Button Odustani
        private void button4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
            
        }

        // Cell click i dohvacanje retka
        private void dgvPopisProizvoda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnemoguciButtonAzuriraj();

            int brojRetka = DohvatiBrojOdabranogRetkaDGV();
            
            txtPronadjeniProizvod.Text = dgvPopisProizvoda.Rows[brojRetka].Cells["Naziv"].Value.ToString();
        }

        private void OnemoguciButtonAzuriraj()
        {
            btnAzuriraj.Enabled = false;
            btnSpremi.Enabled = true;
        }

        private int DohvatiBrojOdabranogRetkaDGV()
        {
            int redak = dgvPopisProizvoda.CurrentCell.RowIndex;
            return redak;
        }

        // Trazilica proizvoda
        private void txtTrazilicaProizvoda_TextChanged(object sender, EventArgs e)
        {
            Namjesti_CMB_Filtar();
            var uneseniTekst = (sender as TextBox).Text;
            
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Proizvod.Trazilica_DohvatiSveDostupneProizvodeZaKorisnika(uneseniTekst, korisnickoIme);

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //comboBox odabir
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.SelectedIndex == 0)
            {
                NapuniDGVProizvodima(korisnickoIme);
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                FiltirajPoCijeniUzlazno(korisnickoIme);
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                FiltirajPoCijeniSilazno(korisnickoIme);
            }
            else
            {
                FiltirajPoNazivu(korisnickoIme);
            }
        }

        // Metode filtriranja - Cijena i Naziv
        private void FiltirajPoCijeniSilazno(string korisnickoIme)
        {
            
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Proizvod.FiltirajPoCijeniSilazno(korisnickoIme);

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FiltirajPoNazivu(string korisnickoIme)
        {
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Proizvod.FiltirajPoNazivuUzlazno(korisnickoIme);

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FiltirajPoCijeniUzlazno(string korisnickoIme)
        {
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Proizvod.FiltirajPoCijeniUzlazno(korisnickoIme);

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Button Spremi
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int ocjena = DohvatiOcjenuProizvoda();
            string komentar = DohvatiKomentarKorisnika();
            string datum = DohvatiDatum();

            IspisProizvoda dohvaceniRedak = DohvatiRedakProizvoda();
            double cijena = dohvaceniRedak.Cijena;
            string nazivProizvoda = dohvaceniRedak.Naziv;

            int idKorisnik = TOOL_Korisnik.DohvatiIDKorisnika(korisnickoIme);
            int idProizvod = TOOL_Proizvod.DohvatiIDProizvoda(cijena, nazivProizvoda);

            Recenzija novaRecenzija = StvoriNoviObjektZaBazuPodataka(idKorisnik, idProizvod, ocjena, datum, komentar);

            if (novaRecenzija == null)
            {
                throw (new NepotpunaPoljaPriUnosu("Molimo Vas da odaberete proizvod i unosete sve potrebne vrijednosti"));
            }
            else
            {
                CRUD_Recenzija.KreirajNovuRecenziju(novaRecenzija);
            }
            UcitajWindowsFormuKorisnickaRecenzija();

        }

        private IspisProizvoda DohvatiRedakProizvoda()
        {
            IspisProizvoda redak = dgvPopisProizvoda.CurrentRow.DataBoundItem as IspisProizvoda;
            return redak;
        }

        // Stvori novi objekt + metoda Dohvati datum
        private Recenzija StvoriNoviObjektZaBazuPodataka(int idKorisnik, int idProizvod, int ocjena, string datum, string komentar)
        {
            Recenzija nova = new Recenzija();
            nova.IDKorisnik = idKorisnik;
            nova.IDProizvod = idProizvod;
            nova.Ocjena = ocjena;
            nova.Datum = Convert.ToDateTime(datum);
            nova.Komentar = komentar;

            return nova;
        }

        private string DohvatiDatum()
        {
            string datum = dateTimePicker1.Text;
            return datum;
        }

        // Spremanje ili azuriranje podataka u tablicu
        //private void SpremanjePodatakaUTablicu(TOOL_Proizvod dohvaceniRedak, bool postojiProizvod, int idKorisnika, int ocjena, string datum, string komentar)
        //{
        //    using (var db = new Entiteti())
        //    {
        //        if (postojiProizvod == false)
        //        {
        //            TOOL_Recenzija recenzija = new TOOL_Recenzija();
        //            recenzija.Komentar = komentar;
        //            recenzija.Datum = Convert.ToDateTime(datum);
        //            recenzija.Ocjena = ocjena;
        //            recenzija.IDProizvod = dohvaceniRedak.ID;
        //            recenzija.IDKorisnik = idKorisnika;

        //            db.Recenzija.Add(recenzija);
        //            db.SaveChanges();

        //            MessageBox.Show("Spremljene su promjene");
        //            NapuniPovijestRecenzijaKorisnika(korisnik);
        //        }
        //        else
        //        {
        //            TOOL_Recenzija recenzija = new TOOL_Recenzija();
        //            recenzija.Komentar = komentar;
        //            recenzija.Datum = Convert.ToDateTime(datum);
        //            recenzija.Ocjena = ocjena;
        //            recenzija.IDProizvod = dohvaceniRedak.ID;
        //            recenzija.IDKorisnik = idKorisnika;

        //            db.SaveChanges();

        //            MessageBox.Show("Azurirane su promjene");
        //            NapuniPovijestRecenzijaKorisnika(korisnik);

        //        }
        //    }
        //}

        // Dohvacanje retka, komentara i ocjene
        private PovijestRecenzija DohvatiRedak()
        {
            PovijestRecenzija recenzija = dgvPovijestRecenzija.CurrentRow.DataBoundItem as PovijestRecenzija;
            return recenzija;
        }

        private string DohvatiKomentarKorisnika()
        {
            string unos = txtboxKomentar.Text;
            return unos;
        }

        private int DohvatiOcjenuProizvoda()
        {
            if (radioB1.Checked) return 1;
            else if (radioB2.Checked) return 2;
            else if (radioB3.Checked) return 3;
            else if (radioB4.Checked) return 4;
            else return 5;
        }

        // Button Azuriraj
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string datum = DohvatiDatum();
            string komentar = DohvatiKomentarKorisnika();
            int ocjena = DohvatiOcjenuProizvoda();

            PovijestRecenzija redak = DohvatiRedakPovijestRecenzija();

            int idProizvod = TOOL_Recenzija.DohvatiIDProizvod(redak.ID);
            int idKorisnik = TOOL_Recenzija.DohvatiIDKorisnik(redak.ID);
            int id = redak.ID;

            Recenzija dohvacenaRecenzija = TOOL_Recenzija.DohvatiRecenziju(redak);

            CRUD_Recenzija.AzurirajOdabranuRecenziju(dohvacenaRecenzija, id, idProizvod, idKorisnik, datum, ocjena, komentar);

            UcitajWindowsFormuKorisnickaRecenzija();
        }

        // Button Obrisi
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            PovijestRecenzija odabranaRecenzija = DohvatiRedakPovijestRecenzija();

            Recenzija recenzija = TOOL_Recenzija.DohvatiRecenziju(odabranaRecenzija);

            CRUD_Recenzija.ObrisiOdabranuRecenziju(recenzija);

            UcitajWindowsFormuKorisnickaRecenzija();
        }

        // Dohvacanje retka iz DGV Povijest recenzija
        private PovijestRecenzija DohvatiRedakPovijestRecenzija()
        {
            PovijestRecenzija redak = dgvPovijestRecenzija.CurrentRow.DataBoundItem as PovijestRecenzija;
            return redak;
        }

        private void dgvPovijestRecenzija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OnemoguciButtonSpremi();
            
            PovijestRecenzija recenzija = DohvatiRedakPovijestRecenzija();

            PrikaziOdabranePodatke(recenzija);
        }

        private void OnemoguciButtonSpremi()
        {
            btnSpremi.Enabled = false;
            btnAzuriraj.Enabled = true;
        }

        private void PrikaziOdabranePodatke(PovijestRecenzija recenzija)
        {
            txtPronadjeniProizvod.Text = recenzija.Proizvod;
            dateTimePicker1.Value = Convert.ToDateTime(recenzija.Datum.ToString());
            
            // Namjestanje radio buttona
            int ocjena = recenzija.Ocjena;
            switch (ocjena)
            {
                case 1:
                    radioB1.Enabled = true;
                    break;
                case 2:
                    radioB2.Enabled = true;
                    break;
                case 3:
                    radioB3.Enabled = true;
                    break;
                case 4:
                    radioB4.Enabled = true;
                    break;
                case 5:
                    radioB5.Enabled = true;
                    break;
            }

            txtboxKomentar.Text = recenzija.Komentar;
        }
    }
}
