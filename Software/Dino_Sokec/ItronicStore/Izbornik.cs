using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItronicStore
{
    public partial class Izbornik : Form
    {
        private string korisnickoImeLogina;

        public Izbornik()
        {
            InitializeComponent();
        }

        public Izbornik(string korisnickoIme)
        {
            InitializeComponent();
            this.korisnickoImeLogina = korisnickoIme;
        }

        private void btnRecenzija_Click(object sender, EventArgs e)
        {
            var forma2 = new KorisnickaRecenzija(korisnickoImeLogina);
            forma2.PostaviPrethodnuFormu(this);
            forma2.Show();
            this.Hide();

            //this.Hide();
            //var form2 = new KorisnickaRecenzija(korisnickoImeLogina);
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();


        }
    }
}
