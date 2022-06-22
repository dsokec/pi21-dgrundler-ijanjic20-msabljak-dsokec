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
    }
}
