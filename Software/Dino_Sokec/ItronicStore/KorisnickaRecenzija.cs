using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItronicStore;

namespace ItronicStore
{
    public partial class KorisnickaRecenzija : Form
    {
        private string korisnik;
        Izbornik izbornik;

        internal void PostaviPrethodnuFormu(Izbornik x)
        {
            izbornik = x;
        }

        public KorisnickaRecenzija()
        {
            InitializeComponent(); 
        }

        public KorisnickaRecenzija(string korisnickoImeLogina)
        {
            InitializeComponent();
            this.korisnik = korisnickoImeLogina;
        }

        private void KorisnickaRecenzija_Load(object sender, EventArgs e)
        {
            //NapuniDGVPremaLoginKorisnika();
            NapuniDGVProizvodima(korisnik);
            comboBox1.SelectedIndex = 0;
            NapuniPovijestRecenzijaKorisnika(korisnik);
            NapuniTekstualniOkvirKorisnika(korisnik);
            radioB5.Checked = true;
        }

        private void NapuniTekstualniOkvirKorisnika(string korisnik)
        {
            txtKorisnickoIme.Text = korisnik;
            ImeiPrezimeKorisnika(korisnik);
        }

        

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

        private void NapuniDGVProizvodima(string korisnik)
        {
            using(var db = new Entiteti())
            {
                //var upit = from x in db.Proizvod
                //           join y in db.Recenzija on x.ID equals y.IDProizvod into proizvodGrupa
                //           from m in proizvodGrupa.DefaultIfEmpty()
                //           join z in db.Korisnik on m.IDKorisnik equals z.ID into korisnikGrupa
                //           from kj in korisnikGrupa.DefaultIfEmpty()
                //           where kj.KorisnickoIme != korisnik

                //           select new
                //           {
                //               x.Naziv,
                //               x.Cijena,
                //               x.Kolicina
                //           };


                //var upit = from x in db.Proizvod
                //           where !db.Recenzija.Any(f => f.)


                // treba se ispraviti
                var upit = from x in db.Proizvod
                           //join y in db.Recenzija on x.ID equals y.IDProizvod
                           //join z in db.Korisnik on y.IDKorisnik equals z.ID

                           select new { x.Naziv, x.Cijena, x.Kolicina };

                dgvPopisProizvoda.DataSource = null;
                dgvPopisProizvoda.DataSource = upit.ToList();
                // radi
                dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                // broj redaka u DGV-u
                dgvPopisProizvoda.RowsAdded += RowsAdded;
                dgvPopisProizvoda.RowsRemoved += RowsRemoved;
            }

        }

        private void RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblBrojRedaka.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        private void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblBrojRedaka.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        //private void NapuniDGVPremaLoginKorisnika()
        //{
        //    using (var db = new Entiteti())
        //    {
        //        var upit = from x in db.Korisnik
        //                   where x.KorisnickoIme == korisnik
        //                   select new { Ime = x.Ime, Prezime = x.Prezime, Email = x.Email };
        //        dgvPopisProizvoda.DataSource = upit.ToList();
        //    }
        //}

        // Button odustani
        private void button4_Click(object sender, EventArgs e)
        {
            izbornik.Show();
            this.Dispose();
            //this.Hide();
            //Izbornik forma = new Izbornik();
            //forma.Show();
        }

        private void dgvPopisProizvoda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int redak = dgvPopisProizvoda.CurrentCell.RowIndex;
            txtPronadjeniProizvod.Text = dgvPopisProizvoda.Rows[redak].Cells["Naziv"].Value.ToString();
        }

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

        // Spremanje ili azuriranje podataka u tablicu
        private void SpremanjePodatakaUTablicu(Proizvod dohvaceniRedak, bool postojiProizvod, int idKorisnika, int ocjena, string datum, string komentar)
        {
            using (var db = new Entiteti())
            {
                // Provjera postojanja duplikata
                //bool postojiProizvod = db.Proizvod.Any(proizv => proizv.ID == dohvaceniRedak.ID);

                //bool postojiProizvod = db.Proizvod.Any(x => x.ID.Equals(dohvaceniRedak.ID));

                //var postojiProizvod = (from x in db.Proizvod
                //                       where x.ID == dohvaceniRedak.ID
                //                       select x).FirstOrDefault() != null;

                //var postojiProizvod = (from x in db.Proizvod
                //                       where x.ID == dohvaceniRedak.ID
                //                       select x).Any();

                //var postojiProizvod = from x in db.Proizvod
                //                      where x.ID.ToString().Contains(dohvaceniRedak.ID.ToString())
                //                      select x;

                
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
