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
    public partial class IzbornikAdmin : Form
    {
        public IzbornikAdmin()
        {
            InitializeComponent();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            DolazneReklamacije dolazne = new DolazneReklamacije();
            dolazne.Show();
            this.Hide();
        }

        private void btnGrafickiPrikaz_Click(object sender, EventArgs e)
        {
            GrafickiPrikaz grafickiPrikaz = new GrafickiPrikaz();
            grafickiPrikaz.Show();
            this.Hide();
        }
    }
}
