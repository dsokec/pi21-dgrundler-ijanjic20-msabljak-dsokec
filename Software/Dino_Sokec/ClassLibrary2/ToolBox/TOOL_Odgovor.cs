using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary2.ToolBox;
using ClassLibrary2.Klase;

namespace ItronicStore
{
    public static class TOOL_Odgovor
    {
        public static List<PovijestOdgovoraReklamacija> DohvatiSveOdgovoreneReklamacijeAdmina(string korisnickoImeAdmin)
        {
            int idAdmina = DohvatiIDAdmina(korisnickoImeAdmin);
            using (var db = new Entiteti())
            {
                var pov = from x in db.Odgovor
                          join r in db.Reklamacija on x.IDReklamacija equals r.IDReklamacija
                          join p in db.Proizvod on r.IDProizvod equals p.ID
                          join k in db.Korisnik on r.IDKorisnik equals k.ID
                          where x.IDAdmin == idAdmina
                          select new PovijestOdgovoraReklamacija
                          {
                              Prijavljeno = r.Datum,
                              Korisnik = k.KorisnickoIme,
                              Proizvod = p.Naziv,
                              Prigovor = r.Opis,
                              Zaprimljeno = x.Datum,
                              Objasnjenje = x.Odgovor1
                          };
                return pov.ToList();
            }
        }

        public static List<PovratniOdgovori> DohvatiSvePovratneOdgovoreKorisnik(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Odgovor
                           join a in db.Admin on x.IDAdmin equals a.ID
                           join r in db.Reklamacija on x.IDReklamacija equals r.IDReklamacija
                           join p in db.Proizvod on r.IDProizvod equals p.ID
                           join k in db.Korisnik on r.IDKorisnik equals k.ID
                           where k.KorisnickoIme == korisnickoIme
                           select new PovratniOdgovori
                           {
                               Podneseno = r.Datum,
                               KorisnickoIme = k.KorisnickoIme,
                               Proizvod = p.Naziv,
                               Prigovor = r.Opis,
                               Odgovoreno = x.Datum,
                               Admin = a.KorisnickoIme,
                               Objasnjenje = x.Odgovor1
                           };
                return upit.ToList();
            }
        }

        private static int DohvatiIDAdmina(string korisnickoImeAdmin)
        {
            using (var db = new Entiteti())
            {
                var id = from x in db.Admin
                         where x.KorisnickoIme == korisnickoImeAdmin
                         select x.ID;
                return id.FirstOrDefault();
            }
        }
    }
}