using System;

namespace ClassLibrary2
{
    public class IspisRecenzija
    {
        public string KorisnickoIme { get; internal set; }
        public string Proizvod { get; internal set; }
        public int Ocjena { get; internal set; }
        public DateTime Datum { get; internal set; }
        public string Komentar { get; internal set; }
    }
}