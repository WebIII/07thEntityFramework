07thEntityFramework

De output van de Seeding-Querying-saving-data:
```
Database created

---Loading all brewers, ordered by name---
Bavik
De Graal
De Leeuw
Duvel Moortgat
InBev
Palm Breweries
Roman

---Loading the brewer with id 1---
Brewer with id 1: Bavik

---Filtering the brewers:  brewers whose name starts with b---
Bavik

---Filtering the brewers:  brewers from Leuven--
InBev

---Filtering the brewers: brewers with more than 4 beers, ordered by name---
Bavik
Duvel Moortgat
InBev

----Filtering the brewers: brewers with a beer starting with the letter B. ---
Bavik
InBev
Roman

---All beers from brewer with id 1---
Bavik Pils  0.40
Ezel Bruin  2.50
Ezel Wit  1.80
Wittekerke Rosé  1.30
Wittekerke Speciale  1.80
Wittekerke  1.00

---All brewers from Leuven, print the name and the number of beers---
InBev 5

---All brewers from Leuven, print the name and the number of beers - Use projections---
InBev 5

---Loading multiple relationships: all brewers, print name, location and number of beers--
Bavik                           Bavikhove                    6
De Graal                                                     0
De Leeuw                                                     0
Duvel Moortgat                      Puurs                    6
InBev                              Leuven                    5
Palm Breweries                                               4
Roman                          Oudenaarde                    4

---Including multiple levels: All brewers from the first category---
Bavik
Palm Breweries
Roman

---Explicit loading: all english courses from bavik--
Brewing beer Advanced

---Explicit loading: all courses from bavik--
Brewing beer Advanced
Bierbrouwen basis

---All brewers with NrOfBeers > 4--
InBev: 5
Bavik: 6
Duvel Moortgat: 6

---Overerving--
Brewing beer Advanced

---Add: Create Brewer Gentse Gruut, Rembert Dodoensdreef, 9000 Gent ---

---Add in ICollection : add Course 'Hoppe'---

---Update : Give Gentse Gruut a new address in Roeselare---

---Delete : remove Gentse Gruut---
Number of brewers before delete: 8
Number of brewers after delete: 7

---Transactions, multiple operations in 1 save, change the turnover of the first to brewers---

---Create Brewer De Koninck, Mechelsesteenweg 291, 2018 Antwerpen--
Number of cities before insert:7
Number of cities after insert:8

---Removing relationships: Remove the first Beer from Bavik - Delete --

```
