using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Klase
{
    public class PovijestRecenzija
    {
        public int ID { get; set; }
        //public string Ime { get; set; }
        //public string Prezime { get; set; }
        public string Proizvod { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
        public string  Komentar { get; set; }
    }
}
