//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using ItronicStore;

//namespace ItronicStore
//{
//    public partial class RegistrationWF : Form
//    {
//        public RegistrationWF()
//        {
//            InitializeComponent();
//        }

//        //private void btnRegistrirajSe_Click(object sender, EventArgs e)
//        //{
//        //    string korisnickoIme = txtUnosKorisnickoIme.Text;
//        //    string lozinka = txtUnosLozinka.Text;
//        //    string potvrdaLozinke = txtUnosPotvrdaLozinke.Text;

            

//        //    // Poruke upozorenja
//        //    string g = "Greska";
//        //    string u = "Uspjeh";

//        //    if ((Prazna_su_polja_za_Unos()) == false)
//        //    {

//        //        if(lozinka == potvrdaLozinke)
//        //        {
//        //            if (true)
//        //            {
//        //                // Uspjesna registracija
//        //                string uspjehPoruka = "Uspjesno ste registrirani. Mozete se prijaviti.";
//        //                MessageBox.Show(uspjehPoruka, u, MessageBoxButtons.OK, MessageBoxIcon.Information);

//        //                Povratak_U_LoginFormu();
//        //            }
//        //            else
//        //            {
//        //                // Korisnik vec postoji
//        //                string rezerviranoPoruka = "Korisnicko ime vec postoji. Pokusajte ponovno.";
//        //                MessageBox.Show(rezerviranoPoruka, g, MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //            }
//        //        }
//        //        else
//        //        {
//        //            // Nepodudarnost dviju lozinki
//        //            string nepodudarnostPoruka = "Lozinke se ne podudaraju.";
//        //            MessageBox.Show(nepodudarnostPoruka, g, MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //        }
//        //    }
//        //    else
//        //    {
//        //        // Nepotpuna polja
//        //        string popuniPoruka = "Popunite sva potrebna polja";
//        //        MessageBox.Show(popuniPoruka, g, MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //    }
//        //}

//        //private bool Prazna_su_polja_za_Unos()
//        //{
//        //    string korisnickoIme = txtUnosKorisnickoIme.Text;
//        //    string lozinka = txtUnosLozinka.Text;
//        //    string potvrdaLozinke = txtUnosPotvrdaLozinke.Text;

//        //    bool provjera1 = string.IsNullOrEmpty(korisnickoIme);
//        //    bool provjera2 = string.IsNullOrEmpty(lozinka);
//        //    bool provjera3 = string.IsNullOrEmpty(potvrdaLozinke);

//        //    if (provjera1 & provjera2 & provjera3) return true;
//        //    else return false;
//        //}

//        private void Povratak_U_LoginFormu()
//        {
//            this.Close();
//        }

//        private void btnOdustani_Click(object sender, EventArgs e)
//        {
//            Povratak_U_LoginFormu();
//        }

//        private void btnPrijaviSe_Click(object sender, EventArgs e)
//        {
//            Povratak_U_LoginFormu();
//        }

//        private void RegistrationWF_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
