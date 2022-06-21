using ClassLibrary2.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.ToolBox
{
    public static class Proizvod
    {
        public static List<string> DohvatiSveNaziveProizvoda() {
            using (var db = new Entiteti())
            {
                var proizvodi = from x in db.Proizvod
                                select x.Naziv;
                return proizvodi.ToList();
            }
        }

        public static List<string> DohvatiSveProizvode_AdoZ() {
            using (var db = new Entiteti())
            {
                var proizvodi = from x in db.Proizvod
                                orderby x.Naziv
                                select x.Naziv;
                return proizvodi.ToList();
            }
        }

        public static List<OpisProizvoda> DohvatiOpisProizvoda(int idProizvoda)
        {
            using (var db = new Entiteti())
            {
                var opis = from x in db.Proizvod
                           join y in db.Kategorija on x.IDKategorija equals y.ID
                           join z in db.Dobavljac on x.Dobavljac equals z.Dobavljac1
                           select new OpisProizvoda
                           {
                               Dobavljac = z.Dobavljac1,
                               Opis = x.Opis,
                               Kolicina = x.Kolicina
                           };
                return opis.ToList();
            }
        }

        public static List<PorijekloDobavljaca> DohvatiSveDobavljace()
        {
            using (var db = new Entiteti())
            {
                var dobavljaci = from x in db.Dobavljac
                                 select new PorijekloDobavljaca
                                 {
                                     Dobavljac = x.Dobavljac1,
                                     Grad = x.Grad
                                 };
                return dobavljaci.ToList();
            }
        }
        public static List<IspisProizvoda> DohvatiSveProizvode()
        {
            using (var db = new Entiteti())
            {
                var proizvodi = from x in db.Proizvod
                                join y in db.Kategorija on x.IDKategorija equals y.ID
                                select new IspisProizvoda
                                {
                                    Naziv = x.Naziv,
                                    Kategorija = y.Naziv,
                                    Cijena = x.Cijena,
                                };
                return proizvodi.ToList();
            }
        }

        public static List<IspisProizvoda> TraziProizvodPoRijeci(string kljucnaRijec)
        {
            using (var db = new Entiteti())
            {
                var upit = from xy in db.Proizvod
                           join k in db.Kategorija on xy.IDKategorija equals k.ID
                           where xy.Naziv.Contains(kljucnaRijec)
                           select new IspisProizvoda
                           {
                               Naziv = xy.Naziv,
                               Kategorija = k.Naziv,
                               Cijena = xy.Cijena
                           };
                return upit.ToList();
            }
        }
    }
}
