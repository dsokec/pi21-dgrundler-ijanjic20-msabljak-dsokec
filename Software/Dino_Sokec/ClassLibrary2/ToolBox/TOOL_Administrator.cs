using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.ToolBox
{
    public static class TOOL_Administrator
    {
        public static List<string> DohvatiSveAdministratore()
        {
            using (var db = new Entiteti())
            {
                var admini = from x in db.Admin
                             select x.KorisnickoIme;
                return admini.ToList();
            }
        }
        public static string DohvatiLozinkuZaOdabranogAdministratora(string korisnickoImeAdministratora)
        {
            using (var db = new Entiteti())
            {
                var lozinka = from x in db.Admin
                              where x.KorisnickoIme == korisnickoImeAdministratora
                              select x.Lozinka;
                return lozinka.FirstOrDefault();
            }
        }
        public static List<string> DohvatiSveAdministratore_AdoZ()
        {
            using (var db = new Entiteti())
            {
                var admini = from x in db.Admin
                             orderby x.KorisnickoIme ascending
                             select x.KorisnickoIme;
                return admini.ToList();
            }
        }
    }
}
