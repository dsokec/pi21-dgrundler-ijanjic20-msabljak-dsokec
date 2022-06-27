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