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
    public partial class ReklamacijaWF : Form
    {
        public ReklamacijaWF()
        {
            InitializeComponent();
        }

        private void ReklamacijaWF_Load(object sender, EventArgs e)
        {
            SakrijStupce();
            /*
            textBoxIDKorisnik.Hide();
            labelIDKorisnik.Hide();
            */
        }

        private Reklamacija reklamacija = null;
        private Korisnik korisnik = null;
        private Racun racun = null;
        private Proizvod proizvod = null;
        private void SakrijStupce()
        {
            //dgvReklamacija.AutoGenerateColumns = false;
            dgvReklamacija.DataSource = UpravljanjeReklamacijama.DohvatiSveReklamacije();
            dgvReklamacija.Columns["Feedback"].Visible = false;
            dgvReklamacija.Columns["Korisnik"].Visible = false;
            dgvReklamacija.Columns["Proizvod"].Visible = false;
            dgvReklamacija.Columns["Racun"].Visible = false;
            dgvReklamacija.Columns["IDKorisnik"].Visible = false;
        }

        /*
        private void OdabraniRedak()
        {
            Reklamacija reklamacija = dgvReklamacija.CurrentRow.DataBoundItem as Reklamacija;
            textBoxID.Text = reklamacija.IDReklamacija.ToString();
            textBoxIDProizvod.Text = reklamacija.IDProizvod.ToString();
            textBoxIDRacun.Text = reklamacija.Racun.ToString();
            textBoxIme.Text = reklamacija.Ime.ToString();
        }
        */

        private void dgvReklamacija_SelectionChanged(object sender, EventArgs e)
        {
            Reklamacija reklamacija = dgvReklamacija.CurrentRow.DataBoundItem as Reklamacija;
            textBoxID.Text = reklamacija.IDReklamacija.ToString();
            //textBoxIDProizvod.Text = reklamacija.IDProizvod.ToString();
            //textBoxIDRacun.Text = reklamacija.IDRacun.ToString();
            textBoxIme.Text = reklamacija.Ime.ToString();
            textBoxPrezime.Text = reklamacija.Prezime.ToString();
            textBoxEmail.Text = reklamacija.Email.ToString();
            textBoxOpis.Text = reklamacija.Opis.ToString();

        }

        
        // button Odustani
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // spremi
        private void button1_Click(object sender, EventArgs e)
        {
            NoviZapisWF forma = new NoviZapisWF();
            forma.ShowDialog();
        }

        private void OdrediMaksimalnuVrijednostIDja()
        {

        }

        private void comboBoxIDRacun_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<int> sviIDjevi = UpravljanjeReklamacijama.DohvatiIDjeveProizvoda();

            /*foreach (var item in sviIDjevi)
            {
                comboBoxIDRacun.Items.Add(item);
            }*/

            //comboBoxIDRacun.DataSource = sviIDjevi;
            
            
            /*
            List<Racun> IDjevi = UpravljanjeReklamacijama.DohvatiIDjeveProizvoda();
            foreach (Racun item in IDjevi)
            {
                comboBoxIDRacun.Items.Add(item);
            }
            */

            var ids = UpravljanjeReklamacijama.DohvatiIDjeveProizvoda();
            comboBoxIDRacun.DataSource = ids;

            // comboBoxIDRacun.DataSource = IDjevi;
            //comboBoxIDRacun.DataSource = UpravljanjeReklamacijama.DohvatiIDjeveProizvoda();

        }
    }
}
