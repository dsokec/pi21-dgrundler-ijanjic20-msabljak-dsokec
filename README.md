# Trgovina informatičke opreme Itronic

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime | Model praćenja
------------  | ------------------- | ----- | --------------------- | --------------
Domagoj Grundler | dgrundler@foi.hr | 0016122975 | dgrundler97 | A
Ivan Janjić | ijanjic20@foi.hr | 0016030483 | ivek77 | B
Martin Sabljak | msabljak@foi.hr | 0016123465 | msabljak | B
Dino Šokec | dsokec@foi.hr | 0016123631 | dsokec3110 | B

## Opis domene

Aplikacija Itronic predstavlja sustav upravljanja zalihama u skladištu trgovine informatičke opreme sa svrhom da olakša upravljanje proizvoda i ubrza proces rješavanja zahtjeva kupaca i donošenja pravovremenih odluka. Aplikacija Itronic ujedno je veza između kupca i prodavača. Programska podrška Itronic sastoji se od.... Sastavnice aplikacije Itronic su .... (dijelovi u WinForm)... 
U aplikaciji "ITronic" baziramo se na evidentiranje i upravljanje skladišnim zalihama trgovine informatičke opreme. Osim toga, veliki naglasak stavljamo i na implementaciju sustava prodaje unutar iste aplikacije.

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login i registracija | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik ostvaruje pristup računalnom sustavu prepoznavanjem i autentifikacijom. Korisničke vjerodajnice obično su oblika korisničkog imena i odgovarajuće lozinke.  | ČlanTima
F02 | Upravljanje zalihama | Ravnoteža između plasmana financijskih sredstava u zalihe te povećanja ili zadržavanja zadovoljstva korisnika i krajnjih kupaca. | ČlanTima
F03 | Narudžbenica | Službena ponuda koju je kupac izdao prodavaču, navodeći vrste, količine i dogovorene cijene proizvoda  | ČlanTima
F04 | Prodaja i izdavanje računa | Dokument kojim se potvrđuje kupnja proizvoda poslovne jedinice | ČlanTima
F05 | Recenziranje | Korisnik postavlja ocjenu zadovoljstva i kritički zauzima stav prema nekom proizvodu | ČlanTima
F06 | Evidentiranje i obračunavanje poslovanja | Iskazuje se u financijskim izvještaja interni obračuna poslovanja u obliku prihoda i rashoda | ČlanTima
F07 | Implementacija restful web api servisa | Način komunikacije aplikacije preko Web zahtjeva za prikaz podataka prema metodi CRUD| Martin Sabljak
F08 | Kreiranje naprednih PDF izvješća | Detaljni prikaz računa kupca s nazivom, količinom i ukupnom cijenom kupljenih proizvoda informatičke opreme | ČlanTima
F09 | Korištenje vizualnih prikaza podataka | Slikoviti prikaz internog poslovanja trgovine odnosno prihoda i rashoda u obliku grafikona stupca i pite | ČlanTima
F10 | Implementacija korisničke podrške | Pritiskom tipke F1 tijekom rada na bilo kojoj od formi otvara se chm dokument koji sadrži pomoćne informacije vezane uz formu | ČlanTima

## Tehnologije i oprema

* Visual Studio - računalna programska podrška za izradu zadatka aplikacije
* Visual Paradigm Community - online alat za izrade vizualnih dijagrama rada na projektu, rada aplikacije i prikaz međuovisnosti razina u aplikaciji
* Draw.io - online alat za izradu shematskih prikaza djelovanja i funkcionalnih razina aplikacije
* OpenProject - računalna programska podrška grafičkog prikaza rasporeda projekta u kojem je ilustriran početni i krajnji datum nepromjenjinjivih i sažetih elemenata projekta
* MySQL Workbench - vizualni alat koji pomaže pri modeliranju podataka unutar neke baze podataka i SQL razvoju. Osim toga, nudi izvrstan prikaz ERA modela koji ćemo koristiti u dokumentaciji.
