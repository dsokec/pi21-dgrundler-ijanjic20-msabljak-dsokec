using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class CRUD_Odgovor
    {
        public static void ObrisiOdabraniOdgovorNadReklamacijom(Reklamacija odabranaReklamacija, Admin odabraniAdmin, IspisOdgovora odabraniOdgovorAdmina) {

            Reklamacija reklamacija = DohvatiReklamaciju(odabranaReklamacija);
            Admin admin = DohvatiAdmina(odabraniAdmin);

            Odgovor odgovor = DohvatiOdgovor(reklamacija, admin);

            using (var db = new Entiteti())
            {
                db.Odgovor.Remove(odgovor);
                db.SaveChanges();
            }
        }
        public static void KreirajNoviOdgovorNadReklamacijom(Odgovor noviOdgovor) {
            using (var db = new Entiteti())
            {
                db.Odgovor.Add(noviOdgovor);
                db.SaveChanges();
            }
        }
        public static void AzurirajOdabraniOdgovorNadReklamacijom(Reklamacija odabranaReklamacija, Admin odabraniAdmin, IspisOdgovora azuriraniOdgovor) {
            Reklamacija reklamacija = DohvatiReklamaciju(odabranaReklamacija);
            Admin admin = DohvatiAdmina(odabraniAdmin);

            Odgovor odgovor = DohvatiOdgovor(reklamacija, admin);

            using (var db = new Entiteti())
            {
                odgovor.IDAdmin = odabraniAdmin.ID;
                odgovor.IDReklamacija = odabranaReklamacija.IDReklamacija;
                odgovor.Datum = azuriraniOdgovor.Datum;
                odgovor.Odgovor1 = azuriraniOdgovor.Odgovor;
            }
        }

        private static Odgovor DohvatiOdgovor(Reklamacija reklamacija, Admin admin)
        {
            using (var db = new Entiteti())
            {
                var odgovor = from x in db.Odgovor
                              where x.IDAdmin == admin.ID && x.IDReklamacija == reklamacija.IDReklamacija
                              select x;
                return odgovor.FirstOrDefault();
            }
        }

        private static Admin DohvatiAdmina(Admin odabraniAdmin)
        {
            using (var db = new Entiteti())
            {
                var admin = from x in db.Admin
                            where odabraniAdmin.KorisnickoIme == x.KorisnickoIme
                            select x;
                return admin.FirstOrDefault();
            }
        }

        private static Reklamacija DohvatiReklamaciju(Reklamacija odabranaReklamacija)
        {
            using (var db = new Entiteti())
            {
                var rkl = from x in db.Reklamacija
                          where odabranaReklamacija.IDReklamacija == x.IDReklamacija
                          select x;
                return rkl.FirstOrDefault();
            }
        }

        public static List<IspisOdgovora> DohvatiSveOdgovoreNaReklamacije() {
            using (var db = new Entiteti())
            {
                var odgovori = from x in db.Odgovor
                               join a in db.Admin on x.IDAdmin equals a.ID
                               join r in db.Relacija on x.ID equals r.IDOdgovor
                               join rkl in db.Reklamacija on r.IDReklamacija equals rkl.IDReklamacija
                               join p in db.Podnesak on rkl.IDReklamacija equals p.IDReklamacija
                               join pro in db.Proizvod on p.IDProizvod equals pro.ID
                               join k in db.Korisnik on rkl.IDKorisnik equals k.ID
                               select new IspisOdgovora
                               {
                                   ImeAdmina = a.KorisnickoIme,
                                   Datum = x.Datum,
                                   Podnositelj = k.KorisnickoIme,
                                   Proizvod = pro.Naziv,
                                   Odgovor = x.Odgovor1
                               };
                return odgovori.ToList();
            }
        }
        public static List<IspisOdgovora> DohvatiSveOdgovoreAdminaNaReklamaciju(Reklamacija odabranaReklamacija, Admin odabraniAdmin)
        {
            using (var db = new Entiteti())
            {
                var odgovori = from x in db.Odgovor
                               join a in db.Admin on x.IDAdmin equals a.ID
                               join r in db.Relacija on x.ID equals r.IDOdgovor
                               join rkl in db.Reklamacija on r.IDReklamacija equals rkl.IDReklamacija
                               join p in db.Podnesak on rkl.IDReklamacija equals p.IDReklamacija
                               join pro in db.Proizvod on p.IDProizvod equals pro.ID
                               join k in db.Korisnik on rkl.IDKorisnik equals k.ID
                               where odabranaReklamacija.IDReklamacija == rkl.IDReklamacija && odabraniAdmin.KorisnickoIme == a.KorisnickoIme
                               select new IspisOdgovora
                               {
                                   ImeAdmina = a.KorisnickoIme,
                                   Datum = x.Datum,
                                   Podnositelj = k.KorisnickoIme,
                                   Proizvod = pro.Naziv,
                                   Odgovor = x.Odgovor1
                               };
                return odgovori.ToList();
            }
        }
    }
}
