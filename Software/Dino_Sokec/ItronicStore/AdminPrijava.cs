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
    public partial class AdminPrijava : Form
    {
        public AdminPrijava()
        {
            InitializeComponent();
        }

        private void AdminPrijava_Load(object sender, EventArgs e)
        {
            NapuniComboBoxKorisnickoIme();
            txtLozinkaAdmin.ReadOnly = true;
        }

        private void NapuniComboBoxKorisnickoIme()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Admin
                           select x.KorisnickoIme;
                cmbImeAdmina.DataSource = upit.ToList();
                cmbImeAdmina.SelectedIndex = 0;
            }
        }

        private void cmbImeAdmina_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabir = cmbImeAdmina.SelectedItem.ToString();
            using (var db = new Entiteti())
            {
                var upit = from x in db.Admin
                           where x.KorisnickoIme.ToString() == odabir
                           select x.Lozinka;
                txtLozinkaAdmin.Text = upit.FirstOrDefault();
                txtLozinkaAdmin.PasswordChar = '*';
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            wfLogin form = new wfLogin();
            form.Show();
        }

        private void btnPrijaviSeAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Izbornik izbornik = new Izbornik();
            izbornik.Show();
        }
    }
}
