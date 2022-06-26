using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Klase
{
    public static class KorisnickoImeKorisnika
    {
        private static string myVar;

        public static string KorisnickoIme
        {
            get { return myVar; }
            set { myVar = value; }
        }


        //public static string KorisnickoIme { get; set; }
    }
}
