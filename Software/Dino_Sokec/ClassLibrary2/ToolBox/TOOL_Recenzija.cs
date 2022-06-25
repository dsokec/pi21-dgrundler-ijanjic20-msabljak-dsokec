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
            using (var db = new Entiteti())
            {
                var upit = from x in db.Recenzija
                           join y in db.Proizvod on x.IDProizvod equals y.ID
                           join z in db.Korisnik on x.IDKorisnik equals z.ID
                           where z.KorisnickoIme == korisnickoIme
                           select new PovijestRecenzija
                           {
                               ID = x.ID,
                               //Ime = z.Ime,
                               //Prezime = z.Prezime,
                               Proizvod = y.Naziv,
                               Ocjena = x.Ocjena,
                               Datum = x.Datum,
                               Komentar = x.Komentar
                           };
                return upit.ToList();
            }
        }
        public static Recenzija DohvatiRecenziju(PovijestRecenzija odabranaRecenzija)
        {
            using (var db = new Entiteti())
            {
                var recenzija = from x in db.Recenzija
                                where odabranaRecenzija.ID == x.ID
                                select x;
                return recenzija.FirstOrDefault();
            }
        }
        public static int DohvatiIDProizvod(int idRecenzije) 
        {
            using (var db = new Entiteti())
            {
                var idProizvod = from x in db.Recenzija
                                 where x.ID == idRecenzije
                                 select x.IDProizvod;
                return idProizvod.FirstOrDefault();
            }
        }

        public static int DohvatiIDKorisnik(int idRecenzije)
        {
            using (var db = new Entiteti())
            {
                var idKorisnik = from x in db.Recenzija
                                 where x.ID == idRecenzije
                                 select x.IDKorisnik;
                return idKorisnik.FirstOrDefault();
            }
        }
    }
}
