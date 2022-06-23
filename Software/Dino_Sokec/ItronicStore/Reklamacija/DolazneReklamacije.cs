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

namespace ItronicStore
{
    public partial class DolazneReklamacije : Form
    {
        private string korisnickoImeAdmin;

        public DolazneReklamacije()
        {
            InitializeComponent();
        }

        public DolazneReklamacije(Admin odabraniAdmin)
        {
            InitializeComponent();
            this.korisnickoImeAdmin = odabraniAdmin.KorisnickoIme;
        }

        private void DolazneReklamacije_Load(object sender, EventArgs e)
        {
            NapisiTkoJePrijavljen(korisnickoImeAdmin);
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
    }
}
