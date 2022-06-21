using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Klase
{
    public class IspisReklamacija
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public string Proizvod { get; internal set; }
        public string KorisnickoIme { get; internal set; }
    }
}
