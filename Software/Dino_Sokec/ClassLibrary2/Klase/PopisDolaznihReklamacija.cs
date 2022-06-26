using System;

namespace ClassLibrary2.ToolBox
{
    public class PopisDolaznihReklamacija
    {
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string KorisnickoIme { get; set; }
        public int IDProizvod { get; set; }
        public string Proizvod { get; set; }
        public double Cijena { get; set; }
        public string Prigovor { get; set; }
    }
}