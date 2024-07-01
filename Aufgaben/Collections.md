# Coole Aufgaben

Das ist funny, weil der erste, Microsoft-Interne Name für C# "Cool" war. Eine Datei endete damals mit `.cool`.

- C -> "C" -> Weil es ähnlich zur Programmiersprache "C" und "C++" ist
- O -> "Object" -> Weil alles ein Objekt (Klasse) ist
- O -> "Oriented" -> "Object-Oriented" -> s. oben
- L -> "Language" -> Sprache, wie in Programmiersprache

Microsoft änderte den Namen vor Release. 😡

## Collections

### Temperaturstatistik

**Szenario:**
Alice und Bob sind Meteorologen und sammeln täglich Temperaturdaten. Sie wollen herausfinden, an welchen Tagen die Temperatur über einem bestimmten Schwellenwert liegt. Deine Aufgabe ist es, ihnen zu helfen, indem du eine Funktion schreibst, die diese Tage findet.

**Input:**
- Eine Liste von Temperaturen (List<int>)
- Ein Schwellenwert (int)

**Output:**
- Eine Liste von Indizes (List<int>), die die Tage repräsentieren, an denen die Temperatur über dem Schwellenwert lag

**Aufgabenstellung:**

1. Schreibe eine Funktion, die eine Liste von Temperaturen und einen Schwellenwert als Parameter erhält.
2. Die Funktion soll die Tage finden, an denen die Temperatur über dem Schwellenwert lag.
3. Wenn die Temperatur an einem Tag über dem Schwellenwert liegt, füge den Index dieses Tages zur Ergebnisliste hinzu.
4. Die Funktion soll die Liste der Indizes zurückgeben.

**Hinweise:**
- Nutze eine Schleife, um durch die Liste der Temperaturen zu iterieren.
- Verwende Kontrollstrukturen, um die Temperatur mit dem Schwellenwert zu vergleichen.
- Achte auf eine klare und verständliche Namensgebung deiner Variablen und Funktionen.

**Beispiel:**

```csharp
Input: [20, 22, 19, 24, 21, 18, 25], 21
Output: [1, 3, 6]

Input: [15, 17, 16, 14, 18, 19, 13], 18
Output: [4, 5]
```

### Durchschnittliche Temperatur berechnen

**Szenario:**
Alice und Bob wollen die durchschnittliche Temperatur einer Woche berechnen. Deine Aufgabe ist es, eine Funktion zu schreiben, die die Temperaturen der Woche nimmt und den Durchschnitt berechnet.

**Input:**
- Eine Liste von Temperaturen (List<int>)

**Output:**
- Der Durchschnitt der Temperaturen (double)

**Aufgabenstellung:**

1. Schreibe eine Funktion, die eine Liste von Temperaturen als Parameter erhält.
2. Die Funktion soll die Summe der Temperaturen berechnen.
3. Teile die Summe durch die Anzahl der Temperaturen, um den Durchschnitt zu berechnen.
4. Die Funktion soll den Durchschnitt der Temperaturen als double zurückgeben.

**Hinweise:**
- Nutze eine Schleife, um durch die Liste der Temperaturen zu iterieren und die Summe zu berechnen.
- Verwende Kontrollstrukturen, um sicherzustellen, dass die Liste nicht leer ist (optional, falls ihr schon Fehlerbehandlung behandeln wollt).
- Achte auf eine klare und verständliche Namensgebung deiner Variablen und Funktionen.

**Beispiel:**

```csharp
Input: [20, 22, 19, 24, 21, 18, 25]
Output: 21.285714285714285

Input: [15, 17, 16, 14, 18, 19, 13]
Output: 16.0
```
