# Projekt-Dokumentation

Gruppe: GIGACHAD | Pascal Oestrich

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  18.08.2023     | 0.1.0   | Projektdokumentation (User-Story, Testfälle, Planung erstellt. Programm: (Planung 1.A, 2.A, 3.A) Realisiert|
|     25.08.2023  | 0.2.0   | Programm: (Planung(4.A, 5.A, 6.A, 7.A)                                                           |
|    01.09.2023  | 0.3.0   |   Programm: Planung(8.A, 9.A)                                                           |
|    03.09.2023  | 1.0.0   |   Programm: Umgeschrieben, OOP, Verbessert                                                          |

## 1 Informieren

### 1.1 Ihr Projekt

Ich programmiere Objektorientiert ein Numberguesser-Spiel. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |       Muss         |   Funktional   | Als ein Nutzer erwarte ich, dass eine zufällige Zahl zwischen 1 und 100 generiert wird. |
| 2  |            Muss     |   Funktional    | Als Nutzer erwarte ich, dass ich die Zahl raten kann. |        
| 3 |            Muss     |   Funktional    | Als Nutzer erwarte ich, wenn ich die Zahl falsch erraten habe, dass ich einen Hinweis bekomme, der sagt, ob die geratene Zahl niedriger als die geheimzahl ist.|   
| 4  |            Muss     |   Funktional    | Als Nutzer erwarte ich, wenn ich die Zahl falsch erraten habe, dass ich einen Hinweis bekomme, der sagt, ob die geratene Zahl höher als die geheimzahl ist.|   
| 5  |            Muss     |   Funktional    | Als Nutzer erwarte ich, wenn ich die Zahl richtig erraten habe, dass ich darauf hingewiesen werde.|
| 6  |            Muss     |   Funktional    | Als Nutzer erwarte ich, dass beim Erraten der Geheimzahl die Anzahl aller  Ratversuche angezeigt wird. |
| 7  |            Muss     |   Funktional    | Als Nutzer erwarte ich, dass das Programm mit Fehlereingabe umgehen kann.|
| 8  |            Kann     |   Qualität    | Als Nutzer erwarte ich, dass das Programm schön geordnet ist.|
| 9  |            Kann     |   Qualität    | Als Nutzer erwarte ich, dass das Programm mich am ende Fragt, ob ich noch spielen möchte.|
| 10  |            Muss     |   Rand    | Als Nutzer erwarte ich, dass das Programm Projektorientiert programmiert wird.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Programm gestartet         |   *Nichts*      |  *Die Variabel random, hat eine Zahl zwischen 1 und 100.*|
|  1.2 |      Programm gestartet + Eingabefeld erscheint        |   102      |    "Die gesuchte Zahl ist zwichen 1 und 100."|
| 2.1  |      Programm gestartet        |   *Nichts*       |    *Eingabefeld erscheint*               |
| 3.1  |        Programm gestartet + Eingabefeld erscheint + Randomzahl ist 45    |    20     | "Die gesuchte Zahl ist grösser als 20."|
| 4.1  |  Programm gestartet + Eingabefeld erscheint + Randomzahl ist 45        |   50     |  "Die gesuchte Zahl ist kleiner als 50."|
| 5.1  |   Programm gestartet + Eingabefeld erscheint + Randomzahl ist 45  |   45     |  "Richtig! Die gesuchte Zahl ist 45."|
| 6.1  |   Programm gestartet + gesuchte Zahl gefunden        |   *Enter*      |  *Die Anzahl an Fehlraten wird angezeigt.*|
| 6.2  |   Programm gestartet + 3 Fehlraten + gesuchte Zahl gefunden        |   *Enter*      | "Sie hatten 3 Fehlraten."|
| 7.1 |   Programm gestartet + Eingabefeld erscheint      |   Schweiz     | "Bitte geben Sie eine Zahl zwischen 1 und 100 ein"|
| 7.2 |   Programm gestartet + Eingabefeld erscheint        |   150     | "Die Zahl befindet sich zwischen 1 und 100."|
| 7.3 |   Programm gestartet + Eingabefeld erscheint        |   -2       | "Die Zahl befindet sich zwischen 1 und 100."|
| 7.3 |   Programm gestartet + Eingabefeld erscheint        |   0       | "Die Zahl befindet sich zwischen 1 und 100."|
| 8.1 |   Programm gestartet + gesuchte Zahl gefunden + Programmende       |   *Nichts*       | *Alles schön abgegrentzt untereinander.*|
| 9.1 |   Programm gestartet + Programmende + Abfrage für nochmal spielen erscheint       |   ja      | *Programm beginnt von neu.*|
| 9.2 |   Programm gestartet + Programmende + Abfrage für nochmal spielen erscheint       |   nein     | *Programm endet.*|
| 10.1 |   *Nichts*       |   *Nichts*       | *Programm ist Projektorientiert programmiert.*|

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |    18.08.2023   |      Pascal Oestrich     |      User-Storys und Testfälle        |        1       |
| 2.A  |     18.08.2023   |     Pascal Oestrich       |      Randomzahl generator        |    0.3           |
| 3.A  |     18.08.2023   |     Pascal Oestrich       |      Hinweisprogrammierung Zahl zu niedrig   |    1           |
| 4.A  |     25.08.2023   |     Pascal Oestrich       |      Hinweisprogrammierung Zahl zu hoch       |    0.8           |
| 5.A  |    25.08.2023   |      Pascal Oestrich     |      Hinweisprogrammierung Zahl gefunden       |        0,5       |
| 6.A  |    25.09.2023   |      Pascal Oestrich     |     Anzahlratversuchamzeige      |        0,5       |
| 7.A  |    25.09.2023   |      Pascal Oestrich     |      Umgang mit Fehlereingaben       |        1       |
| 8.A  |    01.09.2023   |      Pascal Oestrich     |      Schönes Design der Programms       |        1       |
| 9.A  |    01.09.2023   |      Pascal Oestrich     |      Abfrage fürs Weiterspielen       |        0,3       |
| 10.A  |    03.09.2023   |      Pascal Oestrich     |      Umschreiben OOP, Verbessern       |        2       |

7,4 Paketen, 1 Paket = 45 min

Total: 288 min

## 3 Entscheiden

Ich habe mich entschieden, nach Planung zu arbeiten, dazu werde ich bei Bedarf oder bei notwendigen Anpassungen das Programm optimieren.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   18.08.2023    |     Pascal Oestrich      |      1         |         1,5          |
| 2.A  |   18.08.2023    |     Pascal Oestrich      |      1         |         1,5          |
| 3.A  |   18.08.2023    |     Pascal Oestrich      |      1         |         1,5          |
| 4.A  |   25.08.2023    |     Pascal Oestrich      |      0,8         |         1          |
| 5.A  |   25.08.2023    |     Pascal Oestrich      |      0,5         |         0,8          |
| 6.A  |   25.08.2023    |     Pascal Oestrich      |      0,5         |         1          |
| 7.A  |   25.08.2023    |     Pascal Oestrich      |      1         |         0,8          |
| 8.A  |   1.09.2023    |     Pascal Oestrich      |      1         |         1.5          |
| 9.A  |   1.09.2023    |     Pascal Oestrich      |      0,3         |         0,3          |

9.9 Pakete, 1 Paket = 45 min

Total = 445.5 min

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| 1.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |   
| 1.2 |   08.09.2023    |    OK      |    Pascal Oestrich    |      
| 2.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 3.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 4.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 5.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 6.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 6.2 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 7.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 7.2 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 7.3 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 7.3 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 8.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 9.1 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 9.2 |   08.09.2023    |    OK      |    Pascal Oestrich    |
| 10.1|   08.09.2023    |    OK      |    Pascal Oestrich    |

Das Programm läuft einwandfrei.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
