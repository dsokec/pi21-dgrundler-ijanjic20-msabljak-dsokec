# Trgovina informatičke opreme "Itronic"

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime | Model praćenja
------------  | ------------------- | ----- | --------------------- | --------------
Domagoj Grundler | dgrundler@foi.hr | 0016122975 | dgrundler97 | A
Ivan Janjić | ijanjic20@foi.hr | 0016030483 | ivek77 | B
Martin Sabljak | msabljak@foi.hr | 0016123465 | msabljak | B
Dino Šokec | dsokec@foi.hr | 0016123631 | dsokec3110 | B

## Opis domene

Aplikacija Itronic predstavlja sustav upravljanja zalihama u skladištu trgovine informatičke opreme sa svrhom da olakša upravljanje proizvoda i ubrza proces rješavanja zahtjeva kupaca i donošenja pravovremenih odluka. Aplikacija Itronic ujedno je veza između kupca i prodavača koja je evidentirana u centraliziranoj bazi podataka. Veliki naglasak stavljamo i na implementaciju sustava prodaje unutar iste aplikacije. 

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava, registracija i administracija korisnika | Forma za prijavu u sustav i administraciju prava ovisno o ulozi korisnika. Prijava se ostavruje unosom korisničkog imena i odgovarajuće lozinke. | Ivan Janjić
F02 | Upravljanje zalihama na skladištu | Ravnoteža između plasmana financijskih sredstava u zalihe te povećanja ili zadržavanja zadovoljstva korisnika i krajnjih kupaca. | Domagoj Grundler
F03 | Kupovina proizvoda u trgovini | Službena ponuda koju je kupac izdao prodavaču, navodeći vrste, količine i dogovorene cijene proizvoda. Kao rezultat djelovanja ove funkcionalnosti dobiva se narudžbenica. | Domagoj Grundler
F04 | Prodaja proizvoda i izdavanje računa | Dokument kojim se potvrđuje kupnja proizvoda poslovne jedinice | Martin Sabljak
F05 | Recenziranje informatičkih proizvoda | Korisnik postavlja ocjenu zadovoljstva i kritički zauzima stav prema nekom proizvodu | Dino Šokec
F06 | Evidentiranje i obračunavanje poslovanja informatičke trgovine | Iskazuje se u financijskim izvještajima interni obračuna poslovanja u obliku prihoda i rashoda | Dino Šokec
F07 | Kreiranje naprednih PDF izvješća informatičke trgovine | Detaljna izvješća unutar kojih su sadržane informacije potrebne za efikasno vođenje trgovine. Informacije će biti prikazane i u vizualnom obliku, tamo gdje je to moguće. | Ivan Janjić
F08 | Zaprimanje reklamacija od strane kupca | U slučaju da je potrebno, sustav pomoću kojeg će kupci moći pokrenuti postupak reklamacije. | Dino Šokec
F09 | Katalog informatičkih proizvoda trgovine | Pregled dostupnih informatičkih proizvoda kupcu na raspolaganje. Kupac može odabrati određeni broj proizvoda iz ponude ili kupiti jedan proizvod. | Martin Sabljak
F10 | Nabava informatičke robe | Informatički proizvodi nabavljuju se od dobavljača prema sklopljenom ugovoru i ažurira se stanje skladišta prema nabavljenoj robi u trgovini. | Domagoj Grundler
F11 | Servis informatičkih proizvoda | Izvršava se popravak i zamjena neispravnog informatičkog proizvoda uz predočeno jamstvo kupca. Popravak i zamjena provode se u roku od dva tjedna. | Martin Sabljak
F12 | Usporedba i pregled lista želja proizvoda | Kupac uspoređuje dva ili više proizvoda zbog što bolje odluke u kupovini jednog ili više proizvoda. Kupac pregledavajući informatičke proizvode u trgovini može sastaviti popis željenih proizvoda za buduću kupovinu u trgovini. | Ivan Janjić

## Tehnologije i oprema

* Visual Studio - računalna programska podrška za izradu zadatka aplikacije
* Visual Paradigm Community - online alat za izrade vizualnih dijagrama rada na projektu, rada aplikacije i prikaz međuovisnosti razina u aplikaciji
* Draw.io - online alat za izradu shematskih prikaza djelovanja i funkcionalnih razina aplikacije
* OpenProject - računalna programska podrška grafičkog prikaza rasporeda projekta u kojem je ilustriran početni i krajnji datum nepromjenjinjivih i sažetih elemenata projekta
* MySQL Workbench - vizualni alat koji pomaže pri modeliranju podataka unutar neke baze podataka i SQL razvoju. Osim toga, nudi izvrstan prikaz ERA modela koji ćemo koristiti u dokumentaciji.
* Četiri računala bazirana na operacijskom sustavu Windows
