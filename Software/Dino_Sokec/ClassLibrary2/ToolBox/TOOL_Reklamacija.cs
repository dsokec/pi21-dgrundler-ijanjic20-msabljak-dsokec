using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.Klase;

namespace ClassLibrary2.ToolBox
{
    public static class TOOL_Reklamacija
    {
        public static List<PopisProizvodaReklamacija> DohvatiSveDostupneProizvode(string korisnickoIme)
        {
            int idKorisnika = DohvatiIDKorisnika(korisnickoIme);

            int[] idIzvrsenihReklamacija = DohvatiIDjeveIzvrsenihReklamacija(idKorisnika);

            using (var db = new Entiteti())
            {
                var popis = from p in db.Proizvod
                            join kat in db.Kategorija on p.IDKategorija equals kat.ID
                            where !idIzvrsenihReklamacija.Contains(p.ID)
                            select new PopisProizvodaReklamacija
                            {
                                ID = p.ID,
                                Proizvod = p.Naziv,
                                Kategorija = kat.Naziv,
                                Cijena = p.Cijena
                                
                            };
                return popis.ToList();
            }
        }

        public static List<PopisDolaznihReklamacija> DohvatiSveNeodgovoreneReklamacije()
        {
            int[] idReklamacija = DohvatiSveIDReklamacije();
            using (var db = new Entiteti())
            {
                var upit = from x in db.Reklamacija
                           join k in db.Korisnik on x.IDKorisnik equals k.ID 
                           join p in db.Proizvod on x.IDProizvod equals p.ID 
                           where !idReklamacija.Contains(x.IDReklamacija)
                           select new PopisDolaznihReklamacija
                           {
                               ID = x.IDReklamacija,
                               Datum = x.Datum,
                               KorisnickoIme = k.KorisnickoIme,
                               IDProizvod = p.ID,
                               Proizvod = p.Naziv,
                               Cijena = p.Cijena,
                               Prigovor = x.Opis
                           };
                return upit.Distinct().ToList();
            }
        }

        private static int[] DohvatiSveIDReklamacije()
        {
            using (var db = new Entiteti())
            {
                var id = from x in db.Odgovor
                         select x.IDReklamacija;
                return id.ToArray();
            }
        }

        private static int[] DohvatiIDjeveIzvrsenihReklamacija(int idKorisnika)
        {
            using (var db = new Entiteti())
            {
                var id = from x in db.Reklamacija
                         where x.IDKorisnik == idKorisnika
                         select x.IDProizvod;
                return id.ToArray();
            }
        }

        private static int DohvatiIDKorisnika(string korisnickoImeKorisnika)
        {
            using (var db = new Entiteti())
            {
                var id = from x in db.Korisnik
                         where x.KorisnickoIme == korisnickoImeKorisnika
                         select x.ID;
                return id.FirstOrDefault();
            }
        }

        public static List<PovijestReklamacija> NapuniPovijestReklamacijaKorisnika(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var upit = from r in db.Reklamacija
                           join p in db.Proizvod on r.IDProizvod equals p.ID
                           join k in db.Korisnik on r.IDKorisnik equals k.ID
                           where k.KorisnickoIme == korisnickoIme
                           select new PovijestReklamacija
                           {
                               ID = r.IDReklamacija,
                               Datum = r.Datum,
                               Proizvod = p.Naziv,
                               Prigovor = r.Opis,
                               KorisnickoIme = k.KorisnickoIme
                           };
                return upit.ToList();
            }
        }

        public static object DohvatiSveNajstarijeReklamacije()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Reklamacija
                           join k in db.Korisnik on x.IDKorisnik equals k.ID
                           join p in db.Proizvod on x.IDProizvod equals p.ID
                           orderby x.Datum ascending
                           select new PopisDolaznihReklamacija
                           {
                               ID = x.IDReklamacija,
                               Datum = x.Datum,
                               KorisnickoIme = k.KorisnickoIme,
                               IDProizvod = p.ID,
                               Proizvod = p.Naziv,
                               Cijena = p.Cijena,
                               Prigovor = x.Opis
                           };
                return upit.ToList();
            }
        }

        public static object DohvatiReklamacijeOsobeAdoZ()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Reklamacija
                           join k in db.Korisnik on x.IDKorisnik equals k.ID
                           join p in db.Proizvod on x.IDProizvod equals p.ID
                           orderby k.KorisnickoIme ascending
                           select new PopisDolaznihReklamacija
                           {
                               ID = x.IDReklamacija,
                               Datum = x.Datum,
                               KorisnickoIme = k.KorisnickoIme,
                               IDProizvod = p.ID,
                               Proizvod = p.Naziv,
                               Cijena = p.Cijena,
                               Prigovor = x.Opis
                           };
                return upit.ToList();
            }
        }

        public static object DohvatiSveNajnovijeReklamacije()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Reklamacija
                           join k in db.Korisnik on x.IDKorisnik equals k.ID
                           join p in db.Proizvod on x.IDProizvod equals p.ID
                           orderby x.Datum descending
                           select new PopisDolaznihReklamacija
                           {
                               ID = x.IDReklamacija,
                               Datum = x.Datum,
                               KorisnickoIme = k.KorisnickoIme,
                               IDProizvod = p.ID,
                               Proizvod = p.Naziv,
                               Cijena = p.Cijena,
                               Prigovor = x.Opis
                           };
                return upit.ToList();
            }
        }

        public static string DohvatiKategorijuProizvoda(PovijestReklamacija reklamacija)
        {
            using (var db = new Entiteti())
            {
                var kategorija = from x in db.Kategorija
                                 join p in db.Proizvod on x.ID equals p.IDKategorija
                                 where reklamacija.Proizvod == p.Naziv
                                 select x.Naziv;
                return kategorija.FirstOrDefault();
            }
        }

        public static string DohvatiOpisProizvoda(PovijestReklamacija reklamacija)
        {
            using (var db = new Entiteti())
            {
                var opis = from p in db.Proizvod
                           where reklamacija.Proizvod == p.Naziv
                           select p.Opis;
                return opis.FirstOrDefault();
            }
        }

        public static string DohvatiOpisProizvodaString(string nazivProizvoda)
        {
            using (var db = new Entiteti())
            {
                var upit = from p in db.Proizvod
                           where p.Naziv == nazivProizvoda
                           select p.Opis;
                return upit.FirstOrDefault();
            }
        }

        public static Reklamacija DohvatiReklamaciju(PovijestReklamacija odabranaReklamacija)
        {
            using (var db = new Entiteti())
            {
                var reklamacija = from x in db.Reklamacija
                                where odabranaReklamacija.ID == x.IDReklamacija
                                select x;
                return reklamacija.FirstOrDefault();
            }
        }

        public static int DohvatiIDKorisnik(string korisnickoIme)
        {
            using (var db = new Entiteti())
            {
                var id = from x in db.Korisnik
                         where korisnickoIme == x.KorisnickoIme
                         select x.ID;
                return id.FirstOrDefault();
            }
        }

        public static int DohvatiIDProizvod(string nazivProizvoda)
        {
            using (var db = new Entiteti())
            {
                var id = from x in db.Proizvod
                         where nazivProizvoda == x.Naziv
                         select x.ID;
                return id.FirstOrDefault();
            }
        }
    }
}
