using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class CRUD_Recenzija
    {
        public static void ObrisiOdabranuRecenziju(Recenzija odabranaRecenzija) {
            using (var db = new Entiteti())
            {
                var recenzija = db.Recenzija.Where(x => x.ID == odabranaRecenzija.ID).FirstOrDefault();

                db.Recenzija.Remove(recenzija);
                db.SaveChanges();
            }
        }
        public static void KreirajNovuRecenziju(Recenzija novaRecenzija) {
            using (var db = new Entiteti())
            {
                db.Recenzija.Add(novaRecenzija);
                db.SaveChanges();
            }
        }
        public static void AzurirajOdabranuRecenziju(IspisRecenzija odabranaRecenzija) {
            var odabraniKorisnik = DohvatiKorisnika(odabranaRecenzija.KorisnickoIme);
            var odabraniProizvod = DohvatiProizvod(odabranaRecenzija.Proizvod);
            var azuriranaRecenzija = DohvatiRecenziju(odabraniKorisnik, odabraniProizvod);

            using(var db = new Entiteti())
            {
                azuriranaRecenzija.IDKorisnik = odabraniKorisnik.ID;
                azuriranaRecenzija.IDProizvod = odabraniProizvod.ID;
                azuriranaRecenzija.Ocjena = odabranaRecenzija.Ocjena;
                azuriranaRecenzija.Datum = odabranaRecenzija.Datum;
                azuriranaRecenzija.Komentar = odabranaRecenzija.Komentar;

                db.SaveChanges();
            }

        }

        private static Recenzija DohvatiRecenziju(Korisnik odabraniKorisnik, Proizvod odabraniProizvod)
        {
            using(var db = new Entiteti())
            {
                var recenzija = from r in db.Recenzija
                                where (r.IDKorisnik == odabraniKorisnik.ID) && (r.IDProizvod == odabraniProizvod.ID)
                                select r;
                return recenzija.FirstOrDefault();
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

        private static Proizvod DohvatiProizvod(string imeProizvoda)
        {
            using (var db = new Entiteti())
            {
                var proizvod = from x in db.Proizvod
                               where x.Naziv == imeProizvoda
                               select x;
                return proizvod.FirstOrDefault();
            }
        }

        public static List<IspisRecenzija> DohvatiSveRecenzije() {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Recenzija
                           join y in db.Proizvod on x.IDProizvod equals y.ID
                           join k in db.Korisnik on x.IDKorisnik equals k.ID
                           select new IspisRecenzija
                           {
                               KorisnickoIme = k.KorisnickoIme,
                               Proizvod = y.Naziv,
                               Ocjena = x.Ocjena,
                               Datum = x.Datum,
                               Komentar = x.Komentar
                           };
                return upit.ToList();
            }
        }
    }
}
