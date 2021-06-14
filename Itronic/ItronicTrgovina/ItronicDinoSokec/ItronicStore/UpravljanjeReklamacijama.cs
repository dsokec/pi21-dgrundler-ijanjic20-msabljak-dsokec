using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItronicStore
{
    public class UpravljanjeReklamacijama
    {
        public static List<Reklamacija> DohvatiSveReklamacije()
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static List<Reklamacija> DohvatiSveReklamacijePoEmail(string emailOsobe)
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           where n.Email.Contains(emailOsobe)
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static List<Reklamacija> DohvatiSveReklamacijePoImeIPrezime(string imeOsobe, string prezimeOsobe)
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           where n.Ime.Contains(imeOsobe) && n.Prezime.Contains(prezimeOsobe)
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static List<Reklamacija> DohvatiSveReklamacijePoRacunu(Racun racun)
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           where n.IDRacun == racun.ID
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static List<Reklamacija> DohvatiSveReklamacijePoEmailKorisnika(Korisnik korisnik)
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           where n.Email.Contains(korisnik.Email)
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static List<Reklamacija> DohvatiSveReklamacijePoProizvodu(Proizvod proizvod)
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           where n.IDProizvod == proizvod.ID
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static List<Reklamacija> DohvatiSveReklamacijePoPovratnojInformaciji(Feedback feedback)
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           where n.IDReklamacija == feedback.IDReklamacija
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static List<Reklamacija> DohvatiSveReklamacijePoPovratnojInformacijiKorisnika(Feedback feedback)
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           where n.IDKorisnik == feedback.IDKorisnik
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static List<Reklamacija> DohvatiSveReklamacijePoOpisuProizvoda(Proizvod proizvod)
        {
            List<Reklamacija> SveReklamacije = null;
            using (var db = new entities())
            {
                var dohvacenaReklamacija = from n in db.Reklamacija
                                           where n.Opis.Contains(proizvod.Opis)
                                           select n;
                SveReklamacije = dohvacenaReklamacija.ToList();
            }
            return SveReklamacije;
        }

        public static void StvoriReklamaciju(Reklamacija reklamacija)
        {
            using (var db = new entities())
            {
                db.Reklamacija.Add(reklamacija);
                db.SaveChanges();
            }
        }

        public static void ObrisiReklamaciju(Reklamacija reklamacija)
        {
            using (var db = new entities())
            {
                var odabranaReklamacija = db.Reklamacija.Where(n => n.IDReklamacija == reklamacija.IDReklamacija).FirstOrDefault();
                var odabranaPovratnaInformacija = db.Feedback.Where(n => n.IDReklamacija == reklamacija.IDReklamacija).FirstOrDefault();

                db.Feedback.Remove(odabranaPovratnaInformacija);
                db.Reklamacija.Remove(odabranaReklamacija);
                db.SaveChanges();
            }
        }

        public static void AzurirajReklamaciju(Reklamacija reklamacija)
        {
            int idReklamacija = reklamacija.IDReklamacija;
            using (var db = new entities())
            {
                var odabranaReklamacija = (from n in db.Reklamacija
                                           where n.IDReklamacija == idReklamacija
                                           select n).SingleOrDefault();
                db.Reklamacija.Attach(odabranaReklamacija);
                //odabranaReklamacija.IDReklamacija = reklamacija.IDReklamacija;
                odabranaReklamacija.IDProizvod = reklamacija.IDProizvod;
                //odabranaReklamacija.IDKorisnik = reklamacija.IDKorisnik;
                //odabranaReklamacija.IDRacun = reklamacija.IDRacun;
                odabranaReklamacija.Ime = reklamacija.Ime;
                odabranaReklamacija.Prezime = reklamacija.Prezime;
                odabranaReklamacija.Email = reklamacija.Email;
                odabranaReklamacija.Opis = reklamacija.Opis;

                db.SaveChanges();
            }
        }

        public static Reklamacija DohvatiZadnjuReklamaciju(Reklamacija reklamacija)
        {
            using (var db = new entities())
            {
                foreach (var item in db.Reklamacija)
                {
                    if (reklamacija.IDReklamacija == item.IDReklamacija)
                    {
                        return item as Reklamacija;
                    }
                }
                return null;
            }
        }

        public static bool ProvjeriEmailKorisnika(Korisnik korisnik)
        {
            Reklamacija odabranaReklamacija = null;
            odabranaReklamacija = DohvatiSveReklamacije().Find(k => k.Email.Contains(korisnik.Email));
            if (odabranaReklamacija != null) return true;
            else return false;
        }
    }
}
