using ItronicClassLibrary;
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

namespace Itronic
{
    public partial class FrmKupac : Form
    {
        public Kupac PovratniKupac;
        public FrmKupac()
        {
            InitializeComponent();
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string brMobitel = txtBrojMobitela.Text;
            string email = txtEmail.Text;
            string adresa = txtAdresa.Text;
            string grad = txtGrad.Text;

            PovratniKupac = Repository.DodajKupca(ime, prezime, brMobitel, email, adresa, grad);
            Close();
        }

        /// <summary>
        /// Kod preuzet sa: https://helpcreator.net/en/index.php/2019/01/01/context-sensitive-help-in-c-and-chm-files/
        /// </summary>
        /// <param name="id"></param>
        private void OpenHelp(int id = -1)
        {
            String help = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            if (id == -1)
            {
                //open help with default settings (do not jump to topic)
                System.Diagnostics.Process.Start(help);
            }
            else
            {
                //jump to topic
                Help.ShowHelp(this, help, HelpNavigator.TopicId, id.ToString());
            }
        }
        private void FrmKupac_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            OpenHelp(1040);
        }
    }
}
