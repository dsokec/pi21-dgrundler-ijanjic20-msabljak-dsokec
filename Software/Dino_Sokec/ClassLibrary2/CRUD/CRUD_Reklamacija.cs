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
                           join p in db.Proizvod on x.IDProizvod equals p.ID
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
        public static List<IspisReklamacija> DohvatiSveDostupneReklamacijeZaAdmina()
        {
            int[] idObradjeneReklamacije = DohvatiSveObradjeneReklamacijeIzTablice();
            using (var db = new Entiteti())
            {
                var dostupne = from r in db.Reklamacija
                               join k in db.Korisnik on r.IDKorisnik equals k.ID
                               join p in db.Proizvod on r.IDProizvod equals p.ID
                               where !idObradjeneReklamacije.Contains(r.IDReklamacija)
                               select new IspisReklamacija
                               {
                                   KorisnickoIme = k.KorisnickoIme,
                                   Ime = k.Ime,
                                   Prezime = k.Prezime,
                                   Datum = r.Datum,
                                   Proizvod = p.Naziv,
                                   Opis = r.Opis
                               };
                return dostupne.ToList();
            }
        }

        private static int[] DohvatiSveObradjeneReklamacijeIzTablice()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Odgovor
                           select x.IDReklamacija;
                return upit.ToArray();
            }
        }

        public static void AzurirajOdabranuReklamaciju_v2(Reklamacija dohvacenReklamacija, int id, int idProizvod, int idKorisnik, string datum, string razlog)
        {
            using (var db = new Entiteti())
            {
                dohvacenReklamacija.IDReklamacija = id;
                dohvacenReklamacija.IDProizvod = idProizvod;
                dohvacenReklamacija.IDKorisnik = idKorisnik;
                dohvacenReklamacija.Opis = razlog;
                dohvacenReklamacija.Datum = Convert.ToDateTime(datum);

                db.Entry(dohvacenReklamacija).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
