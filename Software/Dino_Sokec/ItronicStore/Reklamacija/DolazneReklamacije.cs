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
using ClassLibrary2;
using ClassLibrary2.ToolBox;

namespace ItronicStore
{
    public partial class DolazneReklamacije : Form
    {
        private string korisnickoImeAdmin;

        public DolazneReklamacije(string korisnickoIme)
        {
            InitializeComponent();
            this.korisnickoImeAdmin = korisnickoIme;
        }

        public DolazneReklamacije(Admin odabraniAdmin)
        {
            InitializeComponent();
            this.korisnickoImeAdmin = odabraniAdmin.KorisnickoIme;
        }

        private void DolazneReklamacije_Load(object sender, EventArgs e)
        {
            UcitajWindowsFormu();
            
        }

        private void UcitajWindowsFormu()
        {
            NapisiTkoJePrijavljen(korisnickoImeAdmin);
            PrikaziSveNeodgovoreneDolazneReklamacije();
            PostaviComboBoxBroj();
            DohvatiPovijestOdgovorenihReklamacijaAdmina(korisnickoImeAdmin);
            //PostaviDefaultVrijednostiTXTOkvira();
        }

        private void DohvatiPovijestOdgovorenihReklamacijaAdmina(string korisnickoImeAdmin)
        {
            dgvPovijestReklamacija.DataSource = null;
            dgvPovijestReklamacija.DataSource = TOOL_Odgovor.DohvatiSveOdgovoreneReklamacijeAdmina(korisnickoImeAdmin);

            dgvPovijestReklamacija.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPovijestReklamacija.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PostaviComboBoxBroj()
        {
            cmbFiltar.SelectedIndex = 0;
        }

        private void PrikaziSveNeodgovoreneDolazneReklamacije()
        {
            dgvPopisReklamacija.DataSource = null;
            dgvPopisReklamacija.DataSource = TOOL_Reklamacija.DohvatiSveNeodgovoreneReklamacije();

            SakrijNepotrebneStupce();

            dgvPopisReklamacija.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisReklamacija.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SakrijNepotrebneStupce()
        {
            dgvPopisReklamacija.Columns["ID"].Visible = false;
            dgvPopisReklamacija.Columns["IDProizvod"].Visible = false;


        }

        private void NapisiTkoJePrijavljen(string korisnickoIme)
        {
            lblPrijavljenKao.Text = string.Format($"Vi ste prijavljeni kao {korisnickoIme}");
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            DohvatiOdabraniRedak();
        }

        private void DohvatiOdabraniRedak()
        {
            
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void cmbFiltar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int odabir = cmbFiltar.SelectedIndex;
            if(odabir == 0)
            {
                DohvatiNajnovijeReklamacije();
                
            }
            else if (odabir == 1){
                DohvatiNajstarijeReklamacije();
                
            }
            else 
            {
                DohvatiReklamacijeOsobeAdoZ();
                
            }
        }

        private void DohvatiReklamacijeOsobeAdoZ()
        {
            dgvPopisReklamacija.DataSource = null;
            dgvPopisReklamacija.DataSource = TOOL_Reklamacija.DohvatiReklamacijeOsobeAdoZ();

            SakrijNepotrebneStupce();

            dgvPopisReklamacija.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisReklamacija.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DohvatiNajstarijeReklamacije()
        {
            dgvPopisReklamacija.DataSource = null;
            dgvPopisReklamacija.DataSource = TOOL_Reklamacija.DohvatiSveNajstarijeReklamacije();

            SakrijNepotrebneStupce();

            dgvPopisReklamacija.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisReklamacija.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DohvatiNajnovijeReklamacije()
        {
            dgvPopisReklamacija.DataSource = null;
            dgvPopisReklamacija.DataSource = TOOL_Reklamacija.DohvatiSveNajnovijeReklamacije();

            SakrijNepotrebneStupce();

            dgvPopisReklamacija.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPopisReklamacija.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvPopisReklamacija.Columns["Prigovor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void DolazneReklamacije_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OtvoriHelpFile(1080);
        }
        private void OtvoriHelpFile(int id = -1)
        {
            string help = PutanjaDoHelpFile();
            if (id == -1)
            {
                //otvara se naslovna stranicu u help file
                System.Diagnostics.Process.Start(help);
            }
            else
            {
                //otvora se trazena stranica u help file
                Help.ShowHelp(this, help, HelpNavigator.TopicId, id.ToString());
            }
        }

        private string PutanjaDoHelpFile()
        {
            // absolute path
            string putanja = Path.Combine(new Uri(Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");

            return putanja;
        }

        private void dgvPopisReklamacija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopisDolaznihReklamacija dohvaceni =  DohvatiRedakPopisReklamacija();
            IspuniTekstualneOkvire(dohvaceni);
        }

        private void IspuniTekstualneOkvire(PopisDolaznihReklamacija dohvaceni)
        {
            txtKorisnickoIme.Text = dohvaceni.KorisnickoIme;
            txtProizvod.Text = dohvaceni.Proizvod;
            txtPrigovor.Text = dohvaceni.Prigovor;
        }

        private PopisDolaznihReklamacija DohvatiRedakPopisReklamacija()
        {
            PopisDolaznihReklamacija redak = dgvPopisReklamacija.CurrentRow.DataBoundItem as PopisDolaznihReklamacija;
            return redak;
        }
    }
}
