# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

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
| 8  |            Muss     |   Rand    | Als Nutzer erwarte ich, dass das Programm Projektorientiert programmiert wird.|
| 9  |            Kann     |   Qualität    | Als Nutzer erwarte ich, dass das Programm schön geordnet ist.|
| 10  |            Kann     |   Qualität    | Als Nutzer erwarte ich, dass das Programm mich am ende Fragt, ob ich noch spielen möchte.|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

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
| 8.1 |   *Nichts*       |   *Nichts*       | *Programm ist Projektorientiert programmiert.*|
| 9.1 |   Programm gestartet + gesuchte Zahl gefunden + Programmende       |   *Nichts*       | *Alles schön abgegrentzt untereinander.*|
| 10.1 |   Programm gestartet + Programmende + Abfrage für nochmal spielen erscheint       |   ja      | *Programm beginnt von neu.*|
| 10.2 |   Programm gestartet + Programmende + Abfrage für nochmal spielen erscheint       |   nein     | *Programm endet.*|



✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
