using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItronicStore
{
    public class UpravljanjeRecenzijama
    {
        public static List<Recenzija> DohvatiSveRecenzije()
        {
            List<Recenzija> sveRecenzije = null;
            using (var db = new entities())
            {
                var dohvaceniRedak = from n in db.Recenzija
                                     select n;
                sveRecenzije = dohvaceniRedak.ToList();
            }
            return sveRecenzije;
        }

        public static List<Recenzija> DohvatiSveRecenzijePoKorisniku(Korisnik korisnik)
        {
            List<Recenzija> sveRecenzije = null;
            using (var db = new entities())
            {
                var dohvaceniRedak = from n in db.Recenzija
                                     where n.KorisnikID == korisnik.ID
                                     select n;
                sveRecenzije = dohvaceniRedak.ToList();
            }
            return sveRecenzije;
        }

        public static List<Recenzija> DohvatiSveRecenzijePoProizvodu(Proizvod proizvod)
        {
            List<Recenzija> sveRecenzije = null;
            using (var db = new entities())
            {
                var dohvaceniRedak = from n in db.Recenzija
                                     where n.ProizvodID == proizvod.ID
                                     select n;
                sveRecenzije = dohvaceniRedak.ToList();
            }
            return sveRecenzije;
        }

        public static List<Recenzija> DohvatiSveOcjeneRecenzijaZaProizvode(Proizvod proizvod)
        {

            List<Recenzija> sveRecenzije = null;
            using (var db = new entities())
            {
                var dohvaceniRedak = from n in db.Recenzija
                                     from m in db.Korisnik
                                     from x in db.Kategorija
                                     where (n.ID.Equals(proizvod.ID)).Equals(m.ID).Equals(x.ID)
                                     select n;
                sveRecenzije = dohvaceniRedak.ToList();
            }
            return sveRecenzije;

        }

        public static bool ProvjeriNapisanostKomentaraURecenziji(string napisaniKomentar)
        {
            Recenzija odabranaRecenzija = null;
            odabranaRecenzija = DohvatiSveRecenzije().Find(k => k.Komentar.Equals(napisaniKomentar));
            if (odabranaRecenzija != null) return true;
            else return false;
        }

        public static void StvoriRecenziju(Recenzija recenzija)
        {
            using (var db = new entities())
            {
                db.Recenzija.Add(recenzija);
                db.SaveChanges();
            }
        }
        public static void AzurirajRecenziju(Recenzija recenzija)
        {
            int idRecenzija = recenzija.ID;
            using (var db = new entities())
            {
                Recenzija novarecenzija = (from n in db.Recenzija
                                           where n.ID == idRecenzija
                                           select n).SingleOrDefault();
                db.Recenzija.Attach(novarecenzija);
                novarecenzija.ID = recenzija.ID;
                novarecenzija.KorisnikID = recenzija.KorisnikID;
                novarecenzija.ProizvodID = recenzija.ProizvodID;
                novarecenzija.Ocjena = recenzija.Ocjena;
                novarecenzija.Komentar = recenzija.Komentar;
                db.SaveChanges();
            }
        }
        public static void ObrisiRecenziju(Recenzija recenzija)
        {
            using (var db = new entities())
            {
                var odabraniRedak = db.Recenzija.Where(k => k.ID == recenzija.ID).FirstOrDefault();
                db.Recenzija.Remove(odabraniRedak);
                db.SaveChanges();
            }
        }

        public static Recenzija DohvatiIDProizvodRecenzije(Proizvod proizvod)
        {
            Recenzija pronadeniIDPRoizvoda = null;
            pronadeniIDPRoizvoda = DohvatiSveRecenzije().Find(k => k.ProizvodID == proizvod.ID);
            return pronadeniIDPRoizvoda;
        }
    }
}
