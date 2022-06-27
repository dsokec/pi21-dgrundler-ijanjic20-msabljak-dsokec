using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Klase
{
    public class PovratniOdgovori
    {
        public DateTime Podneseno { get; internal set; }
        public string KorisnickoIme { get; internal set; }
        public string Proizvod { get; internal set; }
        public string Prigovor { get; internal set; }
        public DateTime Odgovoreno { get; internal set; }
        public string Admin { get; internal set; }
        public string Objasnjenje { get; internal set; }
    }
}
