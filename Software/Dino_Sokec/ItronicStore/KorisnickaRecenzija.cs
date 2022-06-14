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
            NapuniDGVProizvodima();
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

        private void ImeiPrezimeKorisnika(string korisnik)
        {
            
            // ime
            using (var db = new Entiteti())
            {
                var upit = from x in db.Korisnik
                           where x.KorisnickoIme.Contains(korisnik)
                           select x.Ime;
                txtIme.Text = upit.FirstOrDefault();
            }

            // prezime
            using (var db = new Entiteti())
            {
                var upit = from x in db.Korisnik
                           where x.KorisnickoIme.Contains(korisnik)
                           select x.Prezime;
                txtPrezime.Text = upit.FirstOrDefault();
            }
            {

            }
        }

        private void NapuniPovijestRecenzijaKorisnika(string korisnik)
        {
            //using (var db = new Entiteti())
            //{

            //    var upit = from x in db.Proizvod
            //               from y in db.Recenzija
            //               from z in db.Korisnik
            //               where (x.ID.Equals(y.IDProizvod).Equals(y.))


            //    //var upit = from x in db.Proizvod
            //    //           join y in db.Recenzija on x.ID equals y.IDProizvod

            //    //           //where y.Korisnik.Equals(korisnik)
            //    //           select new { y.Korisnik.KorisnickoIme, x.Naziv, y.Ocjena };
                
            //    //dgvPovijestRecenzija.DataSource = null;
            //    //dgvPovijestRecenzija.DataSource = upit.ToList();

            //    //dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //}
        }

        private void NapuniDGVProizvodima()
        {
            using(var db = new Entiteti())
            {
                var upit = from x in db.Proizvod
                           select new { x.Naziv, x.Cijena, x.Kolicina };

                dgvPopisProizvoda.DataSource = null;
                dgvPopisProizvoda.DataSource = upit.ToList();
                // radi
                dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }

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
                NapuniDGVProizvodima();
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
            int broj = DohvatiOcjenuProizvoda();
            string komentar = DohvatiKomentarKorisnika();
            Proizvod dohvaceniRedak = DohvatiRedak();
            string krajnjiKorisnik = korisnik;

            //SpremanjePodatakaUTablicu();

            //MessageBox.Show("Ocjena broj " + broj.ToString());
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
