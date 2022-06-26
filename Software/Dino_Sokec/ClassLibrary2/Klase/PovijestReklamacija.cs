using System;

namespace ClassLibrary2.ToolBox
{
    public class PovijestReklamacija
    {
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string Proizvod { get; set; }
        public string Prigovor { get; set; }
    }
}