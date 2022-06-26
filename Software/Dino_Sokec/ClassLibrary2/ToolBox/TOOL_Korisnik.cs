using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ClassLibrary2.ToolBox
{
    public static class TOOL_Korisnik
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
        public static string DohvatiKorisnickoImeKorisnika(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var userName = from x in db.Korisnik
                                   where x.KorisnickoIme == korisnickoIme
                                   select x.KorisnickoIme;
                return userName.FirstOrDefault();
            }
        }

        public static string DohvatiEmailKorisnika(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var email = from x in db.Korisnik
                               where x.KorisnickoIme == korisnickoIme
                               select x.Email;
                return email.FirstOrDefault();
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
        public static string DohvatiLozinkuZaOdabranogKorisnika(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var lozinka = from x in db.Korisnik
                              where x.KorisnickoIme == korisnickoIme
                              select x.Lozinka;
                return lozinka.FirstOrDefault();
            }
        }
        public static int DohvatiIDKorisnika(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var id = from x in db.Korisnik
                         where x.KorisnickoIme == korisnickoIme
                         select x.ID;
                return id.FirstOrDefault();
            }
        }
    }
}
