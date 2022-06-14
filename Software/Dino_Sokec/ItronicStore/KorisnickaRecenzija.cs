﻿using System;
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
    }
}
