using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItronicClassLibrary
{
    /// <summary>
    /// Autor: Domagoj Grundler
    /// 
    /// Statična klasa 'Repository' u kojoj se nalaze metode za rad s bazom podataka
    /// </summary>
    public static class Repository
    {
        public static List<Proizvod> DohvatiSveProizvode()
        {
            using (entities context = new entities())
            {
                var query = from p in context.Proizvods
                            select p;

                return query.ToList();
            }
        }

        public static List<Kategorija> DohvatiSveKategorije()
        {
            using (entities context = new entities())
            {
                var query = from k in context.Kategorijas
                            select k;

                return query.ToList();
            }
        }

        public static List<Proizvod> DohvatiProizvodePoKategoriji(Kategorija kategorija)
        {
            using (entities context = new entities())
            {
                var query = from p in context.Proizvods
                            where p.KategorijaID == kategorija.ID
                            select p;

                return query.ToList();
            }
        }

        public static void DodajProizvod(Kategorija kategorija, string naziv, float prodajnaCijena, float kupovnaCijena, string opis)
        {
            using (entities context = new entities())
            {
                Proizvod noviProizvod = new Proizvod
                {
                    KategorijaID = kategorija.ID,
                    Naziv = naziv,
                    ProdajnaCijena = prodajnaCijena,
                    KupovnaCIjena = kupovnaCijena,
                    Kolicina = 0,
                    Opis = opis
                };

                context.Proizvods.Add(noviProizvod);
                context.SaveChanges();
            }
        }

        public static void AzurirajProizvod(Proizvod odabraniProizvod, Kategorija kategorija, string naziv, float prodajnaCijena, float kupovnaCijena, string opis)
        {
            using (entities context = new entities())
            {
                context.Proizvods.Attach(odabraniProizvod);
                odabraniProizvod.KategorijaID = kategorija.ID;
                odabraniProizvod.Naziv = naziv;
                odabraniProizvod.ProdajnaCijena = prodajnaCijena;
                odabraniProizvod.KupovnaCIjena = kupovnaCijena;
                odabraniProizvod.Opis = opis;
                context.SaveChanges();
            }
        }

        public static void ObrisiProizvod(Proizvod proizvod)
        {
            using (entities context = new entities())
            {
                context.Proizvods.Attach(proizvod);
                context.Proizvods.Remove(proizvod);
                context.SaveChanges();
            }
        }

        public static void PosaljiNarudzbenicu(List<Proizvod> proizvodi, List<int> kolicine)
        {
            if (proizvodi.Count != 0)
            {
                Primka novaPrimka = DodajPrimku();
                for (int i = 0; i < proizvodi.Count; i++)
                {
                    Proizvod proizvodZaDodaju = proizvodi[i];
                    int kolicinaZaDodaju = kolicine[i];

                    DodajStavkuPrimke(novaPrimka, proizvodZaDodaju, kolicinaZaDodaju);
                }
            }
        }

        public static Primka DodajPrimku()
        {
            using (entities context = new entities())
            {
                Primka novaPrimka = new Primka
                {
                    Datum = DateTime.Now.Date
                };
                context.Primkas.Add(novaPrimka);
                context.SaveChanges();

                return novaPrimka;
            }
        }

        public static void DodajStavkuPrimke(Primka primka, Proizvod proizvod, int kolicina)
        {
            using (entities context = new entities())
            {
                context.Primkas.Attach(primka);
                context.Proizvods.Attach(proizvod);

                StavkaPrimke stavkaPrimke = new StavkaPrimke
                {
                    PrimkaID = primka.ID,
                    ProizvodID = proizvod.ID,
                    Kolicina = kolicina
                };

                context.StavkaPrimkes.Add(stavkaPrimke);
                proizvod.Kolicina += kolicina;
                context.SaveChanges();
            }
        }

        public static void PosaljiNarudzbu(List<Proizvod> proizvodi, List<int> kolicine, Kupac kupac)
        {
            Racun noviRacun = DodajRacun(kupac);

            for (int i = 0; i < proizvodi.Count; i++)
            {
                Proizvod proizvodZaDodaju = proizvodi[i];
                int kolicinaZaDodaju = kolicine[i];

                DodajStavkuRacuna(noviRacun, proizvodZaDodaju, kolicinaZaDodaju);
            }
        }

        public static Kupac DodajKupca(string ime, string prezime, string brMobitel, string email, string adresa, string grad)
        {
            using (entities context = new entities())
            {
                Kupac noviKupac = new Kupac
                {
                    Ime = ime,
                    Prezime = prezime,
                    BrojMobitela = brMobitel,
                    Email = email,
                    Adresa = adresa,
                    Grad = grad
                };
                context.Kupacs.Add(noviKupac);
                context.SaveChanges();

                return noviKupac;
            }
        }

        public static Racun DodajRacun(Kupac kupac)
        {
            using (entities context = new entities())
            {
                context.Kupacs.Attach(kupac);
                Racun noviRacun = new Racun
                {
                    KupacID = kupac.ID,
                    Datum = DateTime.Now.Date
                };
                context.Racuns.Add(noviRacun);
                context.SaveChanges();

                return noviRacun;
            }
        }

        public static void DodajStavkuRacuna(Racun racun, Proizvod proizvod, int kolicina)
        {
            using (entities context = new entities())
            {
                context.Racuns.Attach(racun);
                context.Proizvods.Attach(proizvod);
                StavkaRacuna stavkaRacuna = new StavkaRacuna
                {
                    RacunID = racun.ID,
                    ProizvodID = proizvod.ID,
                    Kolicina = kolicina
                };
                context.StavkaRacunas.Add(stavkaRacuna);
                proizvod.Kolicina -= kolicina;
                context.SaveChanges();
            }
        }
    }
}

