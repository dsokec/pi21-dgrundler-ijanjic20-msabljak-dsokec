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
            NapisiTkoJePrijavljen(korisnickoImeAdmin);
            PrikaziSveDolazneReklamacije();
            PostaviComboBoxBroj();
        }

        private void PostaviComboBoxBroj()
        {
            cmbFiltar.SelectedIndex = 0;
        }

        private void PrikaziSveDolazneReklamacije()
        {
            dgvPopisReklamacija.DataSource = null;
            dgvPopisReklamacija.DataSource = TOOL_Reklamacija.DohvatiSveReklamacije();

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
    }
}
