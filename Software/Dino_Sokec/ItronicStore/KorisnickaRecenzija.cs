using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlasaUpravljanja;

namespace ItronicStore
{
    public partial class KorisnickaRecenzija : Form
    {
        // OK 
        private string korisnik;
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
            this.korisnik = korisnickoImeLogina;
        }

        private void KorisnickaRecenzija_Load(object sender, EventArgs e)
        {
            //NapuniDGVPremaLoginKorisnika();

            // x
            NapuniDGVProizvodima(korisnik);

            // Filtiranje
            // OK
            comboBox1.SelectedIndex = 0;

            // OK
            NapuniPovijestRecenzijaKorisnika(korisnik);

            // OK
            NapuniTekstualniOkvirKorisnika(korisnik);

            // OK
            radioB5.Checked = true;
        }

        private void NapuniTekstualniOkvirKorisnika(string korisnik)
        {
            // OK
            txtKorisnickoIme.Text = korisnik;

            // x
            //ImeiPrezimeKorisnika(korisnik);
        }



        // OK
        private void NapuniPovijestRecenzijaKorisnika(string korisnik)
        {
            // radi :)
            using(var db = new Entiteti())
            {
                var upit = from x in db.Recenzija
                           join y in db.Proizvod on x.IDProizvod equals y.ID
                           join z in db.Korisnik on x.IDKorisnik equals z.ID
                           where z.KorisnickoIme == korisnik
                           select new { z.Ime, z.Prezime, y.Naziv, x.Ocjena, x.Datum };

                dgvPovijestRecenzija.DataSource = null;
                dgvPovijestRecenzija.DataSource = upit.ToList();

                dgvPovijestRecenzija.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvPovijestRecenzija.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                lblBrojRedakaPovijest.Text = dgvPovijestRecenzija.Rows.Count.ToString();
            }
            
        }

        // x
        private void NapuniDGVProizvodima(string korisnik)
        {
            using(var db = new Entiteti())
            {

                // @
                dgvPopisProizvoda.DataSource = null;
                //dgvPopisProizvoda.DataSource = upit.ToList();
                
                // OK
                // radi
                dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                // OK
                // broj redaka u DGV-u
                dgvPopisProizvoda.RowsAdded += RowsAdded;
                dgvPopisProizvoda.RowsRemoved += RowsRemoved;
            }

        }

        // OK
        private void RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblBrojRedaka.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        // OK
        private void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblBrojRedaka.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        

       
        // OK
        // Natrag
        private void button4_Click(object sender, EventArgs e)
        {
            // OK
            izbornik.Show();
            this.Dispose();
            
        }

        // OK
        private void dgvPopisProizvoda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int redak = dgvPopisProizvoda.CurrentCell.RowIndex;
            txtPronadjeniProizvod.Text = dgvPopisProizvoda.Rows[redak].Cells["Naziv"].Value.ToString();
        }

        // OK
        private void txtTrazilicaProizvoda_TextChanged(object sender, EventArgs e)
        {
            var uneseniTekst = (sender as TextBox).Text;
            using(var db = new Entiteti())
            {
                var upit = from xy in db.Proizvod
                           where xy.Naziv.Contains(uneseniTekst)
                           select new { Naziv = xy.Naziv, Cijena = xy.Cijena, Kolicina = xy.Kolicina };
                
                dgvPopisProizvoda.DataSource = null;
                dgvPopisProizvoda.DataSource = upit.ToList();
                dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
        }

        // OK
        //comboBox odabir
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.SelectedIndex == 0)
            {
                NapuniDGVProizvodima(korisnik);
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

        // OK
        private void FiltirajPoCijeniSilazno()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Proizvod
                           orderby x.Cijena descending
                           select new { x.Naziv, x.Cijena, x.Kolicina };

                dgvPopisProizvoda.DataSource = null;
                dgvPopisProizvoda.DataSource = upit.ToList();
                dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        // OK
        private void FiltirajPoNazivu()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Proizvod
                           orderby x.Naziv ascending
                           select new { x.Naziv, x.Cijena, x.Kolicina };

                dgvPopisProizvoda.DataSource = null;
                dgvPopisProizvoda.DataSource = upit.ToList();
                dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        // OK
        private void FiltirajPoCijeniUzlazno()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Proizvod
                           orderby x.Cijena ascending
                           select new { x.Naziv, x.Cijena, x.Kolicina };

                dgvPopisProizvoda.DataSource = null;
                dgvPopisProizvoda.DataSource = upit.ToList();
                dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        // OK
        // spremi recenziju
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int ocjena = DohvatiOcjenuProizvoda();
            string komentar = DohvatiKomentarKorisnika();
            Proizvod dohvaceniRedak = DohvatiRedak();
            bool postojiProizvod = ProvjeriJeLiImaDuplikata(dohvaceniRedak);
            int dohvaceniIDKorisnika = DohvatiIDKorisnika(korisnik);
            string datum = dateTimePicker1.Text;

            SpremanjePodatakaUTablicu(dohvaceniRedak, postojiProizvod, dohvaceniIDKorisnika, ocjena, datum, komentar);
            
        }

        // x
        private bool ProvjeriJeLiImaDuplikata(Proizvod dohvaceniRedak)
        {
            using (var db = new Entiteti())
            {
                foreach (var item in db.Proizvod)
                {
                    if(item.ID == dohvaceniRedak.ID)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        // OK
        private int DohvatiIDKorisnika(string korisnik)
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Korisnik
                           where x.KorisnickoIme == korisnik
                           select x.ID;
                return upit.FirstOrDefault();
            }
        }

        // @
        // Spremanje ili azuriranje podataka u tablicu
        private void SpremanjePodatakaUTablicu(Proizvod dohvaceniRedak, bool postojiProizvod, int idKorisnika, int ocjena, string datum, string komentar)
        {
            using (var db = new Entiteti())
            {
                if (postojiProizvod == false)
                {
                    Recenzija recenzija = new Recenzija();
                    recenzija.Komentar = komentar;
                    recenzija.Datum = Convert.ToDateTime(datum);
                    recenzija.Ocjena = ocjena;
                    recenzija.IDProizvod = dohvaceniRedak.ID;
                    recenzija.IDKorisnik = idKorisnika;

                    db.Recenzija.Add(recenzija);
                    db.SaveChanges();

                    MessageBox.Show("Spremljene su promjene");
                    NapuniPovijestRecenzijaKorisnika(korisnik);
                }
                else
                {
                    Recenzija recenzija = new Recenzija();
                    recenzija.Komentar = komentar;
                    recenzija.Datum = Convert.ToDateTime(datum);
                    recenzija.Ocjena = ocjena;
                    recenzija.IDProizvod = dohvaceniRedak.ID;
                    recenzija.IDKorisnik = idKorisnika;

                    db.SaveChanges();

                    MessageBox.Show("Azurirane su promjene");
                    NapuniPovijestRecenzijaKorisnika(korisnik);

                }
            }
        }

        private Proizvod DohvatiRedak()
        {
            Proizvod proizvod = dgvPopisProizvoda.CurrentRow.DataBoundItem as Proizvod;
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
    }
}
