using ClassLibrary2.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.ToolBox
{
    public static class TOOL_Recenzija
    {
        public static List<PovijestRecenzija> NapuniPovijestRecenzijaKorisnika(string korisnickoIme)
        {
            // radi :)
            using (var db = new Entiteti())
            {
                var upit = from x in db.Recenzija
                           join y in db.Proizvod on x.IDProizvod equals y.ID
                           join z in db.Korisnik on x.IDKorisnik equals z.ID
                           where z.KorisnickoIme == korisnickoIme
                           select new PovijestRecenzija
                           {
                               Ime = z.Ime,
                               Prezime = z.Prezime,
                               Proizvod = y.Naziv,
                               Ocjena = x.Ocjena,
                               Datum = x.Datum
                           };
                return upit.ToList();
            }
        }
    }
}
