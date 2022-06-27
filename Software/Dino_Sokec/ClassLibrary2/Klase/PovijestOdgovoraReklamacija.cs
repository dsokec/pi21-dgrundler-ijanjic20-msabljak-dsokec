using System;

namespace ItronicStore
{
    public class PovijestOdgovoraReklamacija
    {
        public DateTime Prijavljeno { get; set; }
        public string Korisnik { get; set; }
        public string Proizvod { get; set; }
        public string Prigovor { get; set; }
        public DateTime Zaprimljeno { get; set; }
        public string Objasnjenje { get; set; }
    }
}