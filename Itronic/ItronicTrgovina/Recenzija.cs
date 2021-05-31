using System;
using System.Collections.Generic;
using System.Text;

namespace Itronic
{
    class Recenzija
    {
        public string Ime { get; set; };
        public string Prezime { get; set; };
        public int ID { get; set; };
        public string Opis { get; set; }

        public Recenzija(string ime, string prezime, string opis) {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Opis = opis;
        }

        public void Ocjenjivanje() { }

        public void Komentiranje() { }
    }
}