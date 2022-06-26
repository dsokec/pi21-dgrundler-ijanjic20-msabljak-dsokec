using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;
using ClassLibrary2.ToolBox;

namespace ItronicStore
{
    public partial class NovaReklamacija : Form
    {
        private string korisnickoIme = null;
        private Izbornik izbornik;
        public NovaReklamacija(Izbornik Izbornik, string korisnickoIme)
        {
            InitializeComponent();
            this.izbornik = Izbornik;
            this.korisnickoIme = korisnickoIme;
            izbornik.Hide();
        }
        
        // Odustani
        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void NovaReklamacija_Load(object sender, EventArgs e)
        {
            UcitajWindowsFormuNovaReklamacija();
        }

        private void UcitajWindowsFormuNovaReklamacija()
        {
            //NapuniTekstualneOkvire();
            NapuniPovijestReklamacijaZaKorisnika(korisnickoIme);
            DohvatiInformacijeOKorisniku(korisnickoIme);
            //DohvatiInformacijeOdabranogProizvodaDGV();
            DohvatiKorisnikuDostupneProizvodeZaReklamaciju(korisnickoIme);
            //DohvatiZaKorisnikaPovijestPodnesenihReklamacija();
            ResetirajWindowsFormuReklamacija();
        }

        private void ResetirajWindowsFormuReklamacija()
        {
            txtRazlog.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Now;
            txtProizvod.Text = string.Empty;
            txtKategorija.Text = string.Empty;
            txtOpis.Text = string.Empty;
        }

        private void NapuniPovijestReklamacijaZaKorisnika(string korisnickoIme)
        {
            dgvPovijestReklamacija.DataSource = null;
            dgvPovijestReklamacija.DataSource = TOOL_Reklamacija.NapuniPovijestReklamacijaKorisnika(korisnickoIme);

            SakrijNepotrebneStupce();
            
            dgvPovijestReklamacija.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPovijestReklamacija.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblPovijest.Text = dgvPovijestReklamacija.Rows.Count.ToString();
        }

        private void SakrijNepotrebneStupce()
        {
            dgvPovijestReklamacija.Columns["ID"].Visible = false;
            dgvPovijestReklamacija.Columns["KorisnickoIme"].Visible = false;
        }

        private void NapuniTekstualneOkvire()
        {
            //txtProizvod.Text = dgvPopisProizvoda.Rows[0].Cells[0].Value.ToString();
            //txtKategorija.Text = dgvPopisProizvoda.Rows[1].Cells[1].Value.ToString();
            //txtOpis.Text = dgvPopisProizvoda.Rows[0].Cells[2].Value.ToString();
        }

        private void DohvatiZaKorisnikaPovijestPodnesenihReklamacija()
        {
            throw new NotImplementedException();
        }

        private void DohvatiKorisnikuDostupneProizvodeZaReklamaciju(string korisnickoIme)
        {
            dgvPopisProizvoda.DataSource = null;
            dgvPopisProizvoda.DataSource = TOOL_Reklamacija.DohvatiSveDostupneProizvode(korisnickoIme);
            
            dgvPopisProizvoda.Columns["ID"].Visible = false;

            dgvPopisProizvoda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisProizvoda.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPopisProizvoda.RowsAdded += RowsAdded;
            dgvPopisProizvoda.RowsRemoved += RowsRemoved;

            lblDostupnost.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        private void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDostupnost.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        private void RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDostupnost.Text = dgvPopisProizvoda.Rows.Count.ToString();
        }

        private void DohvatiInformacijeOdabranogProizvodaDGV()
        {
            throw new NotImplementedException();
        }

        private void DohvatiInformacijeOKorisniku(string korisnickoImeKorisnika)
        {
            txtIme.Text = TOOL_Korisnik.DohvatiImeKorisnika(korisnickoImeKorisnika);
            txtPrezime.Text = TOOL_Korisnik.DohvatiPrezimeKorisnika(korisnickoImeKorisnika);
            txtEmail.Text = TOOL_Korisnik.DohvatiEmailKorisnika(korisnickoImeKorisnika);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string datum = DohvatiDatum();
            string razlog = DohvatiRazlogNaProizvod();
            PopisProizvodaReklamacija popis = DohvatiRedakDostupnihProizvoda();

            string nazivProizvoda = popis.Proizvod;

            int idKorisnik = TOOL_Korisnik.DohvatiIDKorisnika(korisnickoIme);
            int idProizvod = TOOL_Proizvod.DohvatiIDProizvodaNaziv(nazivProizvoda);

            Reklamacija novaReklamacija = StvoriNoviObjektZaTablicuReklamacija(idKorisnik, idProizvod, datum, razlog);

            CRUD_Reklamacija.KreirajNovuReklamaciju(novaReklamacija);
            UcitajWindowsFormuNovaReklamacija();
        }

        private Reklamacija StvoriNoviObjektZaTablicuReklamacija(int idKorisnik, int idProizvod, string datum, string razlog)
        {
            Reklamacija nova = new Reklamacija();
            nova.IDKorisnik = idKorisnik;
            nova.IDProizvod = idProizvod;
            nova.Datum = Convert.ToDateTime(datum);
            nova.Opis = razlog;

            return nova;
        }

        private PopisProizvodaReklamacija DohvatiRedakDostupnihProizvoda()
        {
            PopisProizvodaReklamacija redak = dgvPopisProizvoda.CurrentRow.DataBoundItem as PopisProizvodaReklamacija;
            return redak;
        }

        private string DohvatiRazlogNaProizvod()
        {
            string razlog = txtRazlog.Text;
            return razlog;
        }

        private string DohvatiDatum()
        {
            string datum = dateTimePicker1.Text;
            return datum;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string datum = DohvatiDatum();
            string razlog = DohvatiRazlogNaProizvod();

            PovijestReklamacija redak = DohvatiRedakPovijestReklamacija();

            //string korisnickoIme = redak.
            string nazivProizvoda = redak.Proizvod;
            string korisnickoIme = redak.KorisnickoIme;   

            int idKorisnik = TOOL_Reklamacija.DohvatiIDKorisnik(korisnickoIme);
            int idProizvod = TOOL_Reklamacija.DohvatiIDProizvod(nazivProizvoda);
            int id = redak.ID;

            Reklamacija dohvacenReklamacija = TOOL_Reklamacija.DohvatiReklamaciju(redak);

            CRUD_Reklamacija.AzurirajOdabranuReklamaciju_v2(dohvacenReklamacija, id, idProizvod, idKorisnik, datum, razlog);

            UcitajWindowsFormuNovaReklamacija();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            PovijestReklamacija odabranaReklamacija = DohvatiRedakPovijestReklamacija();

            Reklamacija reklamacija = TOOL_Reklamacija.DohvatiReklamaciju(odabranaReklamacija);

            CRUD_Reklamacija.ObrisiOdabranuReklamaciju(reklamacija);

            UcitajWindowsFormuNovaReklamacija();
        }

        private void dgvPopisProizvoda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OnemoguciButtonAzuriraj();

            int brojRetka = DohvatiBrojOdabranogRetkaDGV();

            IspuniInformacijeOOdabranomProizvodu(brojRetka);
            
            ResetirajGroupBoxReklamacija();
        }

        private void IspuniInformacijeOOdabranomProizvodu(int brojRetka)
        {
            txtProizvod.Text = dgvPopisProizvoda.Rows[brojRetka].Cells["Proizvod"].Value.ToString();
            txtKategorija.Text = dgvPopisProizvoda.Rows[brojRetka].Cells["Kategorija"].Value.ToString();

            string nazivProizvoda = txtProizvod.Text;
            txtOpis.Text = TOOL_Reklamacija.DohvatiOpisProizvodaString(nazivProizvoda);
        }

        private void ResetirajGroupBoxReklamacija()
        {
            txtRazlog.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private int DohvatiBrojOdabranogRetkaDGV()
        {
            int redak = dgvPopisProizvoda.CurrentCell.RowIndex;
            return redak;
        }

        private void OnemoguciButtonAzuriraj()
        {
            btnAzuriraj.Enabled = false;
            btnSpremi.Enabled = true;
        }

        private void dgvPovijestReklamacija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OnemoguciButtonSpremi();

            PovijestReklamacija reklamacija = DohvatiRedakPovijestReklamacija();

            string kategorijaProizvoda = TOOL_Reklamacija.DohvatiKategorijuProizvoda(reklamacija);
            string opisProizvoda = TOOL_Reklamacija.DohvatiOpisProizvoda(reklamacija);

            PrikaziOdabranePodatke(reklamacija, kategorijaProizvoda, opisProizvoda);
        }

        private void PrikaziOdabranePodatke(PovijestReklamacija reklamacija, string kateg, string opis)
        {
            txtProizvod.Text = reklamacija.Proizvod;
            txtRazlog.Text = reklamacija.Prigovor;
            dateTimePicker1.Value = reklamacija.Datum;
            txtKategorija.Text = kateg;
            txtOpis.Text = opis;
        }

        private PovijestReklamacija DohvatiRedakPovijestReklamacija()
        {
            PovijestReklamacija redak = dgvPovijestReklamacija.CurrentRow.DataBoundItem as PovijestReklamacija;
            return redak;
        }

        private void OnemoguciButtonSpremi()
        {
            btnAzuriraj.Enabled = true;
            btnSpremi.Enabled = false;
        }
    }
}
