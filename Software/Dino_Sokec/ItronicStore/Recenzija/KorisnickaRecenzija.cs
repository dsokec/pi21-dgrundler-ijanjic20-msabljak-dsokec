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

namespace ItronicStore
{
    public partial class KorisnickaRecenzija : Form
    {
        // OK 
        private string korisnickoIme;
        Izbornik izbornik;

        // OK
        internal void PostaviPrethodnuFormu(Izbornik x)
        {
            izbornik = x;
        }

        // OK
        public KorisnickaRecenzija()
        {
            InitializeComponent(); 
        }

        // OK
        public KorisnickaRecenzija(string korisnickoImeLogina)
        {
            InitializeComponent();
            this.korisnickoIme = korisnickoImeLogina;
        }

        private void KorisnickaRecenzija_Load(object sender, EventArgs e)
        {
            NapuniDGVProizvodima(korisnickoIme);

            Namjesti_CMB_Filtar();

            NapuniPovijestRecenzijaKorisnika(korisnickoIme);

            NapuniTekstualniOkvirKorisnika(korisnickoIme);

            Namjesti_RadioButton();

        }

        private void Namjesti_RadioButton()
        {
            radioB5.Checked = true;
        }

        private void Namjesti_CMB_Filtar()
        {
            comboBox1.SelectedIndex = 0;
        }

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

        private void RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblBrojRedaka.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        private void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblBrojRedaka.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        // Natrag
        private void button4_Click(object sender, EventArgs e)
        {
            // OK
            izbornik.Show();
            this.Dispose();
            
        }

        private void dgvPopisProizvoda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int brojRetka = DohvatiBrojOdabranogRetkaDGV();
            
            txtPronadjeniProizvod.Text = dgvPopisProizvoda.Rows[brojRetka].Cells["Naziv"].Value.ToString();
        }

        private int DohvatiBrojOdabranogRetkaDGV()
        {
            int redak = dgvPopisProizvoda.CurrentCell.RowIndex;
            return redak;
        }

        private void txtTrazilicaProizvoda_TextChanged(object sender, EventArgs e)
        {
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
                FiltirajPoCijeniUzlazno();
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                FiltirajPoCijeniSilazno();
            }
            else
            {
                FiltirajPoNazivu();
            }
        }

        private void FiltirajPoCijeniSilazno()
        {
            
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Proizvod.FiltirajPoCijeniSilazno();

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FiltirajPoNazivu()
        {
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Proizvod.FiltirajPoNazivuUzlazno();

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FiltirajPoCijeniUzlazno()
        {
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Proizvod.FiltirajPoCijeniUzlazno();

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // spremi recenziju
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int ocjena = DohvatiOcjenuProizvoda();
            string komentar = DohvatiKomentarKorisnika();
            string datum = DohvatiDatum();

            IspisProizvoda dohvaceniRedak = DohvatiRedak();
            double cijena = dohvaceniRedak.Cijena;
            string nazivProizvoda = dohvaceniRedak.Naziv;

            int idKorisnik = TOOL_Korisnik.DohvatiIDKorisnika(korisnickoIme);
            int idProizvod = TOOL_Proizvod.DohvatiIDProizvoda(cijena, nazivProizvoda);

            Recenzija novaRecenzija = StvoriNoviObjektZaBazuPodataka(idKorisnik, idProizvod, ocjena, datum, komentar);

            CRUD_Recenzija.KreirajNovuRecenziju(novaRecenzija);

            NapuniDGVProizvodima(korisnickoIme);
            NapuniPovijestRecenzijaKorisnika(korisnickoIme);
            NapuniTekstualniOkvirKorisnika(korisnickoIme);

        }

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

        private IspisProizvoda DohvatiRedak()
        {
            IspisProizvoda proizvod = dgvPopisProizvoda.CurrentRow.DataBoundItem as IspisProizvoda;
            return proizvod;
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

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string datum = DohvatiDatum();
            string komentar = DohvatiKomentarKorisnika();
            int ocjena = DohvatiOcjenuProizvoda();
            IspisProizvoda redak = DohvatiRedak();
            int idProizvod = TOOL_Proizvod.DohvatiIDProizvoda(redak.Cijena, redak.Naziv);
            int idKorisnik = TOOL_Korisnik.DohvatiIDKorisnika(korisnickoIme);

            Recenzija azurirana = StvoriNoviObjektZaBazuPodataka(idKorisnik, idProizvod, ocjena, datum, komentar);
            
            CRUD_Recenzija.AzurirajOdabranuRecenziju(azurirana);
            
            NapuniDGVProizvodima(korisnickoIme);
            NapuniPovijestRecenzijaKorisnika(korisnickoIme);
            NapuniTekstualniOkvirKorisnika(korisnickoIme);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            IspisRecenzija odabranaRecenzija = DohvatiRedakPovijestRecenzija();
            DohvatiIDKorisnika();
            DohvatiIDProizvoda();

            CRUD_Recenzija.ObrisiOdabranuRecenziju();
        }

        private IspisRecenzija DohvatiRedakPovijestRecenzija()
        {
            IspisRecenzija redak = dgvPovijestRecenzija.CurrentRow.DataBoundItem as IspisRecenzija;
            return redak;
        }
    }
}
