# Projekt-Dokumentation

Beanjump 
Alberto Manser und Samuel Lucena

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | Projektstart |
|       | 1.0.0   | Projektende                                                  |

## 1 Informieren

### 1.1 Ihr Projekt

Ein 3D Dritte Person Platformer spiel in Unity.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss                | Funktional     | Als ein Spieler möchte ich ein Spiel als .exe starten können |
| 2.1  | Muss                 | Funtkional      | Als ein Spieler möchte ich mich nach vorne und hinten bewegen können|
| 2.2 | Muss | Funktional | Als Spieler möchte ich mich von Seite zu Seite bewegen können |
| 3 | Muss | Funktional | Als Spieler möchte ich mit meiner Maus nach oben unter links und rechts schauen können |
| 4 | Muss | Qualität | Als Spieler möchte ich das die Kamera dem Spieler folgt |
| 5 | Muss | Funktional | Als Spieler möchte ich springen können |
| 6 | Muss | Funktional | Als Spieler möchte ich in der Luft springen können |
| 7 | Muss | Funktional | Als Spieler möchte ich auf verschiedene Platformen springen können |
| 8 | Muss | FUnktional | Als Spieler möchte ich das mein Spielstand gespeichtert wird |
| 9 | Muss | Funktional | Als Spieler möchte ich bei einem Fehlsprung sterben |
| 10 | Muss | FUnktional | Als Spieler möchte ich bei tod wiederbelebt werden.  |



### 1.3 Testfälle

| TC-№ | Ausgangslage                                      | Eingabe                                            | Erwartete Ausgabe                                                     |
| ---- | ------------------------------------------------- | -------------------------------------------------- | ---------------------------------------------------------------------- |
| 1.1  | Spiel heruntergeladen                             | Spiel starten                                      | Das Spiel öffnet sich als `.exe`                                      |
| 2.1  | Spieler befindet sich im Spiel                    | W-Taste drücken                                    | Spieler bewegt sich nach vorne                                        |
| 2.2  | Spieler befindet sich im Spiel                    | S-Taste drücken                                    | Spieler bewegt sich nach hinten                                       |
| 2.3  | Spieler befindet sich im Spiel                    | A-Taste drücken                                    | Spieler bewegt sich nach links                                        |
| 2.4  | Spieler befindet sich im Spiel                    | D-Taste drücken                                    | Spieler bewegt sich nach rechts                                       |
| 3.1  | Spieler befindet sich im Spiel                    | Maus nach oben bewegen                             | Kamera zeigt nach oben                                                |
| 3.2  | Spieler befindet sich im Spiel                    | Maus nach unten bewegen                            | Kamera zeigt nach unten                                               |
| 3.3  | Spieler befindet sich im Spiel                    | Maus nach links bewegen                            | Kamera zeigt nach links                                               |
| 3.4  | Spieler befindet sich im Spiel                    | Maus nach rechts bewegen                           | Kamera zeigt nach rechts                                              |
| 4.1  | Spieler bewegt sich im Spiel                      | Spieler bewegt sich in verschiedene Richtungen     | Kamera folgt dem Spieler ohne Verzögerung                              |
| 5.1  | Spieler befindet sich auf einer Plattform         | Leertaste drücken                                  | Spieler springt in die Luft                                           |
| 6.1  | Spieler befindet sich in der Luft                 | Leertaste erneut drücken                           | Spieler springt erneut (Doppelsprung)                                 |
| 7.1  | Spieler steht vor einer höheren Plattform         | Springen                                           | Spieler erreicht die höhere Plattform                                 |
| 8.1  | Spieler beendet das Spiel                         | Spielstand speichern                               | Spielstand wird gespeichert                                           |
| 8.2  | Spiel wird neu gestartet                          | Spielstand laden                                   | Spieler beginnt vom letzten gespeicherten Stand                        |
| 9.1  | Spieler fällt von einer hohen Plattform           | Spieler fällt                                      | Spieler stirbt und verliert ein Leben                                 |
| 10.1 | Spieler ist gestorben                             | Wiederbeleben                                      | Spieler wird an einem bestimmten Punkt (z. B. Startpunkt) wiederbelebt |


### 1.4 Diagramme

Use-Case Diagramm
![image](https://github.com/user-attachments/assets/2a95a72e-0915-4f8f-b107-f032c747f915)


## 2 Planen

## 2 Planen

| AP-№ | Frist       | Zuständig     | Beschreibung                                                                                     | geplante Zeit |
| ---- | ----------- | ------------- | ------------------------------------------------------------------------------------------------ | ------------- |
| 1.1  | 23.08.2024  | Alberto Manser| Grundstruktur des Projekts erstellen                                                             | 45 Minuten    |
| 1.2  | 23.08.2024  | Samuel Lucena | Erste Basis für Spielfigurbewegung festlegen (Vorwärts und Rückwärts mit W- und S-Taste)        | 45 Minuten    |
| 1.3  | 23.08.2024  | Samuel Lucena | Spielszene und Grundumgebung in der Game-Engine erstellen                                       | 45 Minuten    |
| 2.1  | 30.08.2024  | Alberto Manser| Seitwärtsbewegung der Spielfigur mit A- und D-Tasten einrichten                                 | 45 Minuten    |
| 2.2  | 30.08.2024  | Samuel Lucena | Erste Plattformen in die Umgebung einbauen und testen                                           | 45 Minuten    |
| 2.3  | 30.08.2024  | Alberto Manser| Sprungfunktion mit Leertaste implementieren                                                     | 45 Minuten    |
| 3.1  | 06.09.2024  | Alberto Manser| Kamerafolge der Spielfigur einstellen                                                           | 45 Minuten    |
| 3.2  | 06.09.2024  | Samuel Lucena | Doppelsprung ermöglichen, um Bewegung in der Luft zu testen                                     | 45 Minuten    |
| 4.1  | 13.09.2024  | Alberto Manser| Basis für Fehlsprung-Mechanik (Tod bei Sturz) festlegen                                         | 45 Minuten    |
| 4.2  | 13.09.2024  | Alberto Manser| Wiederbelebungspunkt für Spielfigur nach dem Tod definieren                                     | 45 Minuten    |
| 5.1  | 20.09.2024  | Samuel Lucena | Maussteuerung für Kamerablickrichtung (oben, unten, links, rechts)                              | 45 Minuten    |
| 5.2  | 20.09.2024  | Samuel Lucena | Erstellung eines Menübildschirms, z. B. Start und Optionen                                      | 45 Minuten    |
| 6.1  | 27.09.2024  | Samuel Lucena | Speichern und Laden des Spielstands implementieren                                              | 45 Minuten    |
| 6.2  | 27.09.2024  | Alberto Manser| Testfall für die Kamerasteuerung und Anpassungen durchführen                                    | 45 Minuten    |
| 7.1  | 04.10.2024  | Alberto Manser| Zusätzliche Plattformen hinzufügen und Tests durchführen                                        | 45 Minuten    |
| 7.2  | 04.10.2024  | Alberto Manser| Hindernisse und Sammelobjekte hinzufügen als optionale Spiel-Features                           | 45 Minuten    |
| 8.1  | 11.10.2024  | Samuel Lucena | Testfall für Sprung und Doppelsprung erstellen und durchführen                                  | 45 Minuten    |
| 8.2  | 11.10.2024  | Samuel Lucena | Testfall für Bewegung (Vorwärts, Rückwärts, Seitwärts) erstellen und durchführen                | 45 Minuten    |
| 9.1  | 18.10.2024  | Alberto Manser| Testfall für Fehlsprung und Wiederbelebung durchführen                                          | 45 Minuten    |
| 9.2  | 18.10.2024  | Samuel Lucena | Testfall für Speichern und Laden des Spielstands erstellen und durchführen                      | 45 Minuten    |
| 10.1 | 25.10.2024  | Alberto Manser| Performance-Test und Optimierung der Spielfigurbewegungen und Sprünge                           | 45 Minuten    |
| 10.2 | 25.10.2024  | Samuel Lucena | UI-Verbesserungen und Feinschliff an Menü und Interface                                         | 45 Minuten    |
| 11.1 | 01.11.2024  | Alberto Manser| Erstellung der `.exe`-Datei und Finalisierung für die Veröffentlichung                          | 45 Minuten    |
| 11.2 | 01.11.2024  | Alberto Manser | Letzte Tests und Qualitätskontrolle                                                             | 45 Minuten    |


Total: 
24 Arbeitspakete

## 3 Entscheiden

Wegen Komplikationen und der unterschätzung der gebrauchten Zeit für die Texturen haben wir User-Story 8 nicht implementiert.
Wegen einem unvorgesehenem crash der Entwicklungsumgebung wurden all unsere Hitboxen gelöscht, wegen Zeitdruck konnten wir danach nur die Hitbox für einige der Autos und Container wieder hinzufügen.


## 4 Realisieren

| AP-№ | Datum      | Zuständig       | geplante Zeit | tatsächliche Zeit |
| ---- | ---------- | --------------- | ------------- | ----------------- |
| 1.1  | 23.08.2024 | Samuel Lucena   | 0,75 Stunden  | 1 Stunde          |
| 1.2  | 23.08.2024 | Alberto Manser  | 0,75 Stunden  | 0,75 Stunden      |
| 2.1  | 30.08.2024 | Samuel Lucena   | 0,75 Stunden  | 1 Stunde          |
| 2.2  | 30.08.2024 | Alberto Manser  | 0,75 Stunden  | 1 Stunde          |
| 3.1  | 06.09.2024 | Samuel Lucena   | 0,75 Stunden  | 1,5 Stunden       |
| 3.2  | 06.09.2024 | Alberto Manser  | 0,75 Stunden  | 1,25 Stunden      |
| 4.1  | 13.09.2024 | Samuel Lucena   | 0,75 Stunden  | 1 Stunde          |
| 4.2  | 13.09.2024 | Alberto Manser  | 0,75 Stunden  | 0,75 Stunden      |
| 5.1  | 20.09.2024 | Samuel Lucena   | 0,75 Stunden  | 0,75 Stunden      |
| 5.2  | 20.09.2024 | Alberto Manser  | 0,75 Stunden  | 1 Stunde          |
| 6.1  | 27.09.2024 | Samuel Lucena   | 0,75 Stunden  | 1,25 Stunden      |
| 6.2  | 27.09.2024 | Alberto Manser  | 0,75 Stunden  | 0,75 Stunden      |
| 7.1  | 04.10.2024 | Samuel Lucena   | 0,75 Stunden  | nicht abgeschlossen |
| 7.2  | 04.10.2024 | Alberto Manser  | 0,75 Stunden  | nicht abgeschlossen |
| 8.1  | 11.10.2024 | Samuel Lucena   | 0,75 Stunden  | 1 Stunde |
| 8.2  | 11.10.2024 | Alberto Manser  | 0,75 Stunden  | 0,75 Stunden |
| 9.1  | 18.10.2024 | Samuel Lucena   | 0,75 Stunden  | 1,5 Stunden |
| 9.2  | 18.10.2024 | Alberto Manser  | 0,75 Stunden  | nicht abgeschlossen |
| 10.1 | 25.10.2024 | Samuel Lucena   | 0,75 Stunden  | 0,75 Stunden      |
| 10.2 | 25.10.2024 | Alberto Manser  | 0,75 Stunden  | 0,75 Stunden      |
| 11.1 | 01.11.2024 | Samuel Lucena   | 0,75 Stunden  | 1 Stunde          |
| 11.2 | 01.11.2024 | Alberto Manser  | 0,75 Stunden  | 0,75 Stunden      |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 1.11.2024| ok         | Alberto Manser        |
| 2.1  | 1.11.2024| ok         | Alberto Manser        |
| 2.2  | 1.11.2024| ok | Alberto Manser |
| 2.3 | 1.11.2024| ok | Alberto Manser |
| 2.4 | 1.11.2024| ok | Alberto Manser|
| 3.1 | 1.11.2024| ok | Alberto Manser|
| 3.2 | 1.11.2024| ok | Alberto Manser|
| 3.3 | 1.11.2024| ok | Alberto Manser|
| 3.4 | 1.11.2024| ok | Alberto Manser|
| 4.1 | 1.11.2024| ok | Alberto Manser|
| 5.1 | 1.11.2024| ok | Alberto Manser|
| 6.1 | 1.11.2024| ok | Alberto Manser|
| 7.1 | 1.11.2024| ok | Alberto Manser|
| 8.1 | 1.11.2024| nicht realisiert| Alberto Manser
| 9.1 | 1.11.2024| ok aber keine Leben | Alberto Manser|
| 10.1 | 1.11.2024 | ok |Alberto Manser|

Fazit:
Die Funktionen die wir implementieren laufen ohne grosse Probleme, wie sie in den Issues im Github sehen werden die Kontrols nach dem Wiederbeleben ein bisschen komisch was wir leider nicht fixen konnten.

