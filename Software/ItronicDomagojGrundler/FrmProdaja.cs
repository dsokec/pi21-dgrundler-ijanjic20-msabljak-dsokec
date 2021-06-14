﻿using ItronicClassLib;
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
        private DataTable table;
        double ukupnaCijena;
        private List<Proizvod> odabraniProizvodi;
        private List<int> kolicine;
        private Kupac trenutniKupac;
        public FrmProdaja()
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("Naziv", typeof(string));
            table.Columns.Add("Cijena", typeof(double));
            table.Columns.Add("Kolicina", typeof(int));
            table.Columns.Add("Iznos", typeof(double));
            ukupnaCijena = 0;
            odabraniProizvodi = new List<Proizvod>();
            kolicine = new List<int>();
        }

        private void FrmProdaja_Load(object sender, EventArgs e)
        {
            PrikaziProizvode();
            PopuniKategorije();
        }

        private void PopuniKategorije()
        {
            cbKategorija.DataSource = Repository.DohvatiSveKategorije();
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
            dgvProizvodi.Columns["KupovnaCijena"].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Proizvod odabraniProizvod = dgvProizvodi.CurrentRow.DataBoundItem as Proizvod;
            string naziv = odabraniProizvod.Naziv;
            double cijena = odabraniProizvod.KupovnaCIjena;
            if (txtKolicina.Text == "")
            {
                MessageBox.Show("Morate unijeti količinu!");
                return;
            }
            else if (int.Parse(txtKolicina.Text) > odabraniProizvod.Kolicina)
            {
                MessageBox.Show("Nemamo toliko traženog proizvoda! Molimo Vas da upišete manju količinu");
            }
            int kolicina = int.Parse(txtKolicina.Text);
            double iznos = cijena * kolicina;
            table.Rows.Add(naziv, cijena, kolicina, iznos);
            dgvNarudzba.DataSource = table;
            odabraniProizvodi.Add(odabraniProizvod);
            kolicine.Add(kolicina);
            ukupnaCijena += iznos;
            lblUkupnaCijenaIznos.Text = ukupnaCijena.ToString();
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            using (FrmKupac form = new FrmKupac())
            {
                form.ShowDialog();
                trenutniKupac = form.PovratniKupac;
            }

            Racun noviRacun = Repository.DodajRacun(trenutniKupac);

            for (int i = 0; i < odabraniProizvodi.Count; i++)
            {
                Proizvod proizvodZaDodaju = odabraniProizvodi[i];
                int kolicinaZaDodaju = kolicine[i];

                Repository.DodajStavkuRacuna(noviRacun, proizvodZaDodaju, kolicinaZaDodaju);
            }
            Close();
        }

        private void btnMakniFiltriranje_Click(object sender, EventArgs e)
        {
            dgvProizvodi.DataSource = Repository.DohvatiSveProizvode();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = cbKategorija.SelectedItem as Kategorija;
            dgvProizvodi.DataSource = Repository.DohvatiProizvodePoKategoriji(kategorija);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiItronicManual_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://E:\\FOI\\10.semestar(smh)\\PI\\projekt\\chm\\ItronicHelp.chm");
        }
    }
}
