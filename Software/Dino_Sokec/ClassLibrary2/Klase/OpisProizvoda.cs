using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Klase
{
    public class OpisProizvoda
    {
        public string Dobavljac { get; set; }
        public string Opis { get; set; }
        public int Kolicina { get; set; }

        public bool BrojJeManjiOdNule(int broj)
        {
            if(broj < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
