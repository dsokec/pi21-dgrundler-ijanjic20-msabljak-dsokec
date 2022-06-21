using ClassLibrary2.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class CRUD_Reklamacija
    {
        public static void ObrisiOdabranuReklamaciju(Reklamacija odabranaReklamacija) {
            using (var db = new Entiteti())
            {
                var reklamacija = db.Reklamacija.Where(x => x.IDReklamacija == odabranaReklamacija.IDReklamacija).FirstOrDefault();

                db.Reklamacija.Remove(reklamacija);
                db.SaveChanges();
            }
        }
        public static void KreirajNovuReklamaciju(Reklamacija novaReklamacija) {
            using (var db = new Entiteti())
            {
                db.Reklamacija.Add(novaReklamacija);
                db.SaveChanges();
            }
        }
        public static void AzurirajOdabranuReklamaciju(IspisReklamacija odabraniRedak) {

            var odabranaReklamacija = DohvatiReklamaciju(odabraniRedak.ID);
            var odabraniKorisnik = DohvatiKorisnika(odabraniRedak.KorisnickoIme);
            
            using (var db = new Entiteti())
            {
                odabranaReklamacija.IDKorisnik = odabraniKorisnik.ID;
                odabranaReklamacija.Datum = odabraniRedak.Datum;
                odabranaReklamacija.Opis = odabraniRedak.Opis;

                db.SaveChanges();
            }
        }

        private static Korisnik DohvatiKorisnika(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var korisnik = from x in db.Korisnik
                               where x.KorisnickoIme == korisnickoIme
                               select x;
                return korisnik.FirstOrDefault();
            }
        }

        private static Reklamacija DohvatiReklamaciju(int id)
        {
            using(var db = new Entiteti())
            {
                Reklamacija odabranaReklamacija = (from x in db.Reklamacija
                                           where id == x.IDReklamacija
                                           select x).SingleOrDefault();
                return odabranaReklamacija;
            }
        }

        public static List<IspisReklamacija> DohvatiSveReklamacije() {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Reklamacija
                           join y in db.Korisnik on x.IDKorisnik equals y.ID
                           join z in db.Podnesak on x.IDReklamacija equals z.IDReklamacija
                           join p in db.Proizvod on z.IDProizvod equals p.ID
                           select new IspisReklamacija
                           {
                               KorisnickoIme = y.KorisnickoIme,
                               Ime = y.Ime,
                               Prezime = y.Prezime,
                               Datum = x.Datum,
                               Proizvod = p.Naziv,
                               Opis = x.Opis
                           };
                return upit.ToList();
            }
        }
    }
}
