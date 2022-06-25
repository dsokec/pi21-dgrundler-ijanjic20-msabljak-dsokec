using ClassLibrary2.Klase;
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

        //public static void AzurirajOdabranuRecenziju(Recenzija azuriranaRecenzija)
        //{
        //    using (var db = new Entiteti())
        //    {
        //        Recenzija odabrana = DohvatiRecenziju(azuriranaRecenzija);
        //        odabrana.IDKorisnik = azuriranaRecenzija.IDKorisnik;
        //        odabrana.IDProizvod = azuriranaRecenzija.IDProizvod;
        //        odabrana.Komentar = azuriranaRecenzija.Komentar;
        //        odabrana.Ocjena = azuriranaRecenzija.Ocjena;
        //        odabrana.Datum = azuriranaRecenzija.Datum;

        //        db.SaveChanges();
        //    }
        //}

        private static Recenzija DohvatiRecenziju(Recenzija azuriranaRecenzija)
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Recenzija
                           where x.IDKorisnik == azuriranaRecenzija.IDKorisnik && x.IDProizvod == azuriranaRecenzija.IDProizvod
                           select x;
                return upit.FirstOrDefault();
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

        public static void AzurirajOdabranuRecenziju(Recenzija odabrana, int id, int idProizvod, int idKorisnik, string datum, int ocjena, string komentar)
        {
            using (var db = new Entiteti())
            {
                odabrana.ID = id;
                odabrana.IDProizvod = idProizvod;
                odabrana.IDKorisnik = idKorisnik;
                odabrana.Komentar = komentar;
                odabrana.Ocjena = ocjena;
                odabrana.Datum = Convert.ToDateTime(datum);

                db.Entry(odabrana).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
