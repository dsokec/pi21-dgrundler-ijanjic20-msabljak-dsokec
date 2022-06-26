using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.ToolBox
{
    public static class TOOL_Grafikon
    {
        public static List<PrihodTrgovine> DohvatiPrihodKrozGodine()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Obracun
                           select new PrihodTrgovine
                           {
                               Godina = x.Godina,
                               Prihod = x.Prihod
                           };
                return upit.ToList();
            }
        }
        public static List<RashodTrgovine> DohvatiRashodKrozGodine()
        {
            using (var db = new Entiteti())
            {
                var upit = from x in db.Obracun
                           select new RashodTrgovine
                           {
                               Godina = x.Godina,
                               Rashod = x.Rashod
                           };
                return upit.ToList();
            }
        }

        public static List<double> DohvatiPrihodeIzTabliceObracun()
        {
            using (var db = new Entiteti())
            {
                var prihodi = from x in db.Obracun
                             select x.Prihod;
                return prihodi.ToList();
            }
        }

        public static List<int> DohvatiGodineIzTabliceObracun()
        {
            using (var db = new Entiteti())
            {
                var godine = from x in db.Obracun
                             select x.Godina;
                return godine.ToList();
            }
        }

        public static List<double> DohvatiRashodeIzTabliceObracun()
        {
            using (var db = new Entiteti())
            {
                var rashodi = from x in db.Obracun
                              select x.Rashod;
                return rashodi.ToList();
            }
        }

        public static List<int> DohvatiNabavljenoIzTabliceObracun()
        {
            using (var db = new Entiteti())
            {
                var nabavljeno = from x in db.Obracun
                              select x.Nabavljeno;
                return nabavljeno.ToList();
            }
        }

        public static List<int> DohvatiProdanoIzTabliceObracun()
        {
            using (var db = new Entiteti())
            {
                var prodano = from x in db.Obracun
                                 select x.Prodano;
                return prodano.ToList();
            }
        }
    }
}
