# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Trgovina informatičke opreme Itronic

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Domagoj Grundler | dgrundler@foi.hr | 0016122975 | dgrundler
Ivan Janjić | ijanjic20@foi.hr | 0016030483 | ivek77
Martin Sabljak | msabljak@foi.hr | 0016123465 | msabljak
Dino Šokec | dsokec@foi.hr | 0016123631 | dsokec3110

## Opis domene
Umjesto ovih uputa opišite domenu ili problem koji pokrivate vašim  projektom. Domena može biti proizvoljna, ali obratite pozornost da sukladno ishodima učenja, domena omogući primjenu zahtijevanih koncepata kako je to navedeno u sljedećem poglavlju. Priložite odgovarajuće skice gdje je to prikladno.

U aplikaciji "ITronic" baziramo se na evidentiranje i upravljanje skladišnim zalihama trgovine informatičke opreme. Osim toga, veliki naglasak stavljamo i na implementaciju sustava prodaje unutar iste aplikacije.

## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login i registracija | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik ostvaruje pristup računalnom sustavu prepoznavanjem i autentifikacijom. Korisničke vjerodajnice obično su oblika korisničkog imena i odgovarajuće lozinke.  | ČlanTima
F02 | Upravljanje zalihama | Informacijski sustav skladišta |Ravnoteža između plasmana financijskih sredstava u zalihe te povećanja ili zadržavanja zadovoljstva korisnika i krajnjih kupaca. | ČlanTima
F03 | Narudžbenica | Narudžba proizvoda | Službena ponuda koju je kupac izdao prodavaču, navodeći vrste, količine i dogovorene cijene proizvoda  | ČlanTima
F04 | Prodaja i izdavanje računa |  | ...
F05 | Mogućnost recenziranja (?) |  | ...
F06 | Evidentiranje i obračunavanje poslovanja | .... | ...
F07 | Restful web api servis | .... | ...
F08 | Kreiranje naprednih PDF izvješća | .... | ...
F09 | Korištenje vizualnih prikaza podataka | .... | ...

## Tehnologije i oprema
Umjesto ovih uputa jasno popišite sve tehnologije, alate i opremu koju ćete koristiti pri implementaciji vašeg rješenja. Ne zaboravite planirati korištenje tehnologija u aktivnostima kao što su projektni menadžment ili priprema dokumentacije. Tehnologije koje ćete koristiti bi trebale biti javno dostupne, a ako ih ne budemo obrađivali na vježbama u vašoj dokumentaciji ćete morati navesti način preuzimanja, instaliranja i korištenja onih tehnologija koje su neopbodne kako bi se vaš programski proizvod preveo i pokrenuo. Pazite da svi alati koje ćete koristiti moraju imati odgovarajuću licencu.

* Visual Studio
* Visual Paradigm Community
* Draw.io
* OpenProject
* MySQL Workbench
