using System;

namespace KlasaUpravljanja
{
    public class UpravljanjeFinancijama
    {
        //public static List<Financije> DohvatiFinancije()
        //{
        //    List<Financije> financijskaStanja = null;
        //    using (var db = new entities())
        //    {
        //        var dohvaceniRetki = from n in db.Financije
        //                             select n;
        //        financijskaStanja = dohvaceniRetki.ToList();
        //    }
        //    return financijskaStanja;
        //}

        //public static List<Financije> DohvatiFinancijePoRacunu(Racun racun)
        //{
        //    List<Financije> financijskaStanja = null;
        //    using (var db = new entities())
        //    {
        //        var dohvaceniRetki = from n in db.Financije
        //                             where n.IDRacun == racun.ID
        //                             select n;
        //        financijskaStanja = dohvaceniRetki.ToList();
        //    }
        //    return financijskaStanja;
        //}

        //public static List<Financije> DohvatiFinancijePoPrimci(Primka primka)
        //{
        //    List<Financije> financijskaStanja = null;
        //    using (var db = new entities())
        //    {
        //        var dohvaceniRetki = from n in db.Financije
        //                             where n.IDPrimka == primka.ID
        //                             select n;
        //        financijskaStanja = dohvaceniRetki.ToList();
        //    }
        //    return financijskaStanja;
        //}

        //public static float IzracunajProfitZaIzabraniDatum(Financije financije)
        //{
        //    // List<Financije> dohvaceneFinancije = null;
        //    // List<double> sviPrihodi = null;
        //    // List<double> sviRashodi = null;
        //    float sviPrihodi = 0;
        //    float sviRashodi = 0;
        //    using (var db = new entities())
        //    {
        //        var dohvaceniRedak = from n in db.Racun
        //                             from m in db.Primka
        //                             from b in db.Financije
        //                             where ((n.Datum.Equals(m.Datum).Equals(b.Datum)))
        //                             select b.Prihodi;
        //        sviPrihodi = (float)dohvaceniRedak.Sum();

        //        var dohvaceniRedak2 = from n in db.Racun
        //                              from m in db.Primka
        //                              from b in db.Financije
        //                              where ((n.Datum.Equals(m.Datum).Equals(b.Datum)))
        //                              select b.Rashodi;
        //        sviRashodi = (float)dohvaceniRedak2.Sum();
        //    }
        //    return (float)(sviPrihodi - sviRashodi);
        //}

        //public static List<Financije> DohvatiSvePrihodeIRashodeZaDatum(Racun racun, Primka primka)
        //{
        //    List<Financije> dohvaceneFinancije = null;
        //    using (var db = new entities())
        //    {
        //        var dohvaceniRedak = from n in db.Racun
        //                             from m in db.Primka
        //                             from b in db.Financije
        //                             where ((n.Datum.Equals(m.Datum).Equals(b.Datum)))
        //                             select b;
        //        dohvaceneFinancije = dohvaceniRedak.ToList();
        //    }
        //    return dohvaceneFinancije;
        //}
    }
}
