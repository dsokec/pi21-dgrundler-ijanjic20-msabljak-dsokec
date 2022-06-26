using ClassLibrary2.Klase;
using ClassLibrary2.ToolBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NamjestanjeDefaultVrijednosti_KolicinaJeManjaOdNule_VracaTrue()
        {
            bool rezultat = true;

            var opis = new OpisProizvoda();

            bool ishod = opis.BrojJeManjiOdNule(-5);
            Assert.AreEqual(rezultat, ishod);
        }
        [TestMethod]
        public void ProvjeraOsobe_JeLiOsobaPostoji_VracaTrue()
        {
            string ime = "Dragana";
            string korisnickoIme = "ddrokan";
            string trazenoIme = TOOL_Korisnik.DohvatiImeKorisnika(korisnickoIme);
            Assert.AreEqual(ime, trazenoIme);
        }

        public void ProvjeraOsobe_JeLiPrezimePostoji_VracaTrue()
        {
            string prezime = "Drokan";
            string korisnickoIme = "ddrokan";
            string trazenoIme = TOOL_Korisnik.DohvatiPrezimeKorisnika(korisnickoIme);
            Assert.AreEqual(prezime, trazenoIme);
            
        }
    }
}
