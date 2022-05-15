using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItronicStore
{
    public class UpravljanjePovratnimInformacijama
    {
        public static List<Feedback> DohvatiSvePovratneInformacije()
        {
            List<Feedback> SvePovratneInformacije = null;
            using (var db = new entities())
            {
                var dohvacenaPovratnaInformacija = from n in db.Feedback
                                                   where n.Status == 1
                                                   select n;
                SvePovratneInformacije = dohvacenaPovratnaInformacija.ToList();
            }
            return SvePovratneInformacije;
        }

        public static List<Feedback> DohvatiSveOdgovorePovratneInformacije()
        {
            List<Feedback> SviOdgovoriPovratneInformacije = null;
            using (var db = new entities())
            {
                var dohvaceniOdgovor = from n in db.Feedback
                                       where n.Odgovor != null
                                       select n;
                SviOdgovoriPovratneInformacije = dohvaceniOdgovor.ToList();
            }
            return SviOdgovoriPovratneInformacije;
        }

        public static List<Feedback> DohvatiSvePovratneInformacijePoReklamaciji(Reklamacija reklamacija)
        {
            List<Feedback> sviOdgovoriPoReklamaciji = null;
            using (var db = new entities())
            {
                var dohvaceniOdgovorPoReklamaciji = from n in db.Feedback
                                                    where n.IDReklamacija == reklamacija.IDReklamacija
                                                    select n;
                sviOdgovoriPoReklamaciji = dohvaceniOdgovorPoReklamaciji.ToList();
            }
            return sviOdgovoriPoReklamaciji;
        }

        public static List<Feedback> DohvatiSvePovratneInformacijePoKorisniku(Korisnik korisnik)
        {
            List<Feedback> sviOdgovoriPoKorisniku = null;
            using (var db = new entities())
            {
                var dohvaceniOdgovoriPoKorisniku = from n in db.Feedback
                                                   where n.IDKorisnik == korisnik.ID
                                                   select n;
                sviOdgovoriPoKorisniku = dohvaceniOdgovoriPoKorisniku.ToList();
            }
            return sviOdgovoriPoKorisniku;
        }

        public static void StvoriPovratnuInformaciju(Feedback povratnaInformacija)
        {
            using (var db = new entities())
            {
                db.Feedback.Add(povratnaInformacija);
                db.SaveChanges();
            }
        }
        public static void ObrisiPovratnuInformaciju(Feedback povratnaInformacija)
        {
            using (var db = new entities())
            {
                var odabraniRedak = db.Feedback.Where(n => n.IDKorisnik == povratnaInformacija.IDKorisnik).FirstOrDefault();

                db.Feedback.Remove(odabraniRedak);
                db.SaveChanges();
            }
        }

        public static void AzurirajPovratnuInformaciju(Feedback feedback)
        {
            int idPovratnaInformacija = feedback.IDPovratnaInformacija;
            using (var db = new entities())
            {
                var povratnaInformacija = (from n in db.Feedback
                                           where n.IDPovratnaInformacija == idPovratnaInformacija
                                           select n).SingleOrDefault();
                db.Feedback.Attach(povratnaInformacija);
                povratnaInformacija.IDPovratnaInformacija = feedback.IDPovratnaInformacija;
                povratnaInformacija.IDKorisnik = feedback.IDKorisnik;
                povratnaInformacija.IDReklamacija = feedback.IDReklamacija;
                povratnaInformacija.Status = feedback.Status;
                povratnaInformacija.Odgovor = feedback.Odgovor;
                db.SaveChanges();
            }
        }

        public static bool ProvjeraStatusaPovratneInformacije(Feedback feedback)
        {
            Feedback odabranifeedback = null;
            odabranifeedback = DohvatiSvePovratneInformacije().Find(k => k.Status == feedback.Status);
            if (odabranifeedback != null) return true;
            else return false;
        }

        public static List<Feedback> DohvatiSvePovratneInformacijePoStatusu(Feedback feedback)
        {
            List<Feedback> povratneInformacijePoStatusu = null;
            using (var db = new entities())
            {
                var odabranapovratnainformacija = from n in db.Feedback
                                                  where n.Status == feedback.Status
                                                  select n;
                povratneInformacijePoStatusu = odabranapovratnainformacija.ToList();
            }
            return povratneInformacijePoStatusu;
        }
    }
}
