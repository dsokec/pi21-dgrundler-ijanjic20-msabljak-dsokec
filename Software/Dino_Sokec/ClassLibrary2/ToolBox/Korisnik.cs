using ClassLibrary2.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.ToolBox
{
    public static class Korisnik
    {
        public static List<string> DohvatiSveKorisnike()
        {
            using (var db = new Entiteti())
            {
                var korisnici = from x in db.Korisnik
                                select x.KorisnickoIme;
                
                return korisnici.ToList();
            }
        }

        public static List<string> DohvatiSveKorisnike_AdoZ()
        {
            using (var db = new Entiteti())
            {
                var korisnici = from x in db.Korisnik
                                orderby x.KorisnickoIme ascending
                                select x.KorisnickoIme;

                return korisnici.ToList();
            }
        }

        public static string DohvatiImeKorisnika(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var imeKorisnika = from x in db.Korisnik
                                 where x.KorisnickoIme == korisnickoIme
                                 select x.Ime;
                return imeKorisnika.FirstOrDefault();
            }
        }
        public static string DohvatiPrezimeKorisnika(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var prezimeKorisnika = from x in db.Korisnik
                                   where x.KorisnickoIme == korisnickoIme
                                   select x.Prezime;
                return prezimeKorisnika.FirstOrDefault();
            }
        }
    }
}
