using System;
using System.Collections.Generic;
using System.Text;

namespace Itronic
{
    class Reklamacije
    {
        public string Ime { get; set; }
        public int ID { get; private set; }
        public string Opis { get; private set; }
        public string MailAdresa { get; set; }
        public string ArtiklProizvoda { get; private set; }

        // ovo je reklamacija
        public Reklamacije(string ime, string opis, string mailAdresa) {
            this.Ime = ime;
            this.Opis = opis;
            this.MailAdresa = mailAdresa;
        }

        public void UnesiReklamaciju(string opis, string artiklProizvoda)
        {

        }

        public void IzmijeniReklamaciju(string opis, string artiklProizvoda) { }

    }
}
