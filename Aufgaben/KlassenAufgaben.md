# C# - Aufgaben zu Klassen und Objekten

## Tipps zur Arbeit mit Klassen in C#

- Die folgenden Aufgaben machen wenig Sinn mit hilfsmitteln wie ChatGPT oder sonstigen Code-Generatoren zu lösen. Diese Tools sind super um sich Code erklären zu lassen. Mein Tipp, wenn ihr Probleme beim Lösen der Aufgabe habt: Schaut euch unsere Beispiele von gestern, oder die gestern verlinkten Videos zur Wiederholung nochmal an.
- Denke an eine Klasse als eine Blaupause oder ein Template für Objekte. Eine Klasse definiert, welche Eigenschaften (Daten) und Methoden (Funktionen) die Objekte (Instanzen) dieser Klasse haben sollen.
- Wähle aussagekräftige Namen für deine Klassen, Eigenschaften und Methoden. Namen sollten klar und beschreibend sein, damit der Code leicht verständlich ist.
- Ein Konstruktor ist eine spezielle Methode, die beim Erstellen eines Objekts einer Klasse aufgerufen wird und eine Instanz (ein Objekt) von dieser Klasse zurück gibt. Nutze ihn, um die Eigenschaften des Objekts zu initialisieren.
- Methoden in einer Klasse führen Aktionen durch. Sie können Daten verarbeiten und Werte zurückgeben. Achte darauf, dass Methoden nur eine Aufgabe haben und diese klar definiert ist.
- Erstelle Objekte von Klassen, indem du den `new`-Operator verwendest und den Konstruktor der Klasse aufrufst. Beispiel: `Person p = new Person("Mark", "Der_Coolste");`
- Kommentiere deinen Code und dokumentiere, was deine Klassen und Methoden tun. Dies hilft dir und anderen, den Code später besser zu verstehen.


### Aufgabe: Buchverwaltungssystem

**Szenario:**
Alice und Bob betreiben eine kleine Bibliothek und wollen ein einfaches Buchverwaltungssystem erstellen. Sie brauchen eine Klasse `Book`, die grundlegende Informationen über ein Buch speichert und eine Methode, die eine Beschreibung des Buches zurückgibt.

**Aufgabenstellung:**

1. **Klasse erstellen:**
    - Erstelle eine Klasse `Book`.
    - Die Klasse soll die folgenden Eigenschaften (Properties) haben:
        - `Title` (string)
        - `Author` (string)
        - `PublicationYear` (int)
        - `ISBN` (string)
    - Erstelle einen Konstruktor für die Klasse, der die oben genannten Eigenschaften initialisiert.
    - Erstelle eine Methode `GetDescription`, die eine Beschreibung des Buches im folgenden Format zurückgibt:
      `"{Title}" von {Author}, veröffentlicht im Jahr {PublicationYear} (ISBN: {ISBN}).`

2. **Instanzierung und Nutzung:**
    - Erstelle mehrere Instanzen der Klasse `Book` und rufe die Methode `GetDescription` für jede Instanz auf.
    - Gib die Beschreibungen in der Konsole aus.

**Hinweise:**
- Achte auf die richtige Nutzung von Zugriffmodifizierern (public/private) für die Eigenschaften und Methoden.
- Denke daran, den Konstruktor korrekt zu implementieren, damit die Eigenschaften beim Erstellen eines Buchobjekts initialisiert werden.

### Aufgabe: Fahrzeugverwaltungssystem

**Szenario:**
Alice und Bob betreiben ein Autohaus und möchten ein einfaches Fahrzeugverwaltungssystem erstellen. Sie brauchen eine Klasse `Car`, die grundlegende Informationen über ein Fahrzeug speichert und mehrere Methoden bietet, um Informationen über das Fahrzeug abzurufen und zu aktualisieren.

**Aufgabenstellung:**

1. **Klasse erstellen:**
    - Erstelle eine Klasse `Car`.
    - Die Klasse soll die folgenden Eigenschaften (Properties) haben:
        - `Brand` (string)
        - `Model` (string)
        - `Year` (int)
        - `Mileage` (int)
    - Erstelle einen Konstruktor für die Klasse, der die oben genannten Eigenschaften initialisiert.
    - Erstelle eine Methode `GetDescription`, die eine Beschreibung des Fahrzeugs im folgenden Format zurückgibt: `"{Brand} {Model}, Jahr {Year} mit {Mileage} km gefahren."`
    - Erstelle eine Methode `Drive`, die die gefahrenen Kilometer (int) als Parameter erhält und zur bisherigen Kilometerleistung (Mileage) hinzufügt.
    - Erstelle eine Methode `Age`, die das Alter des Fahrzeugs in Jahren berechnet und zurückgibt (ausgehend vom aktuellen Jahr 2024).

2. **Instanzierung und Nutzung:**
    - Erstelle mehrere Instanzen der Klasse `Car` und rufe die Methoden `GetDescription`, `Drive` und `Age` für jede Instanz auf.
    - Gib die Ergebnisse in der Konsole aus.

### Aufgabe: Aufgabenverwaltungssystem

**Szenario:**
Alice und Bob arbeiten an mehreren Projekten und benötigen ein Aufgabenverwaltungssystem, um den Überblick über ihre Aufgaben zu behalten. Sie brauchen eine Klasse `Task`, die grundlegende Informationen über eine Aufgabe speichert und mehrere Methoden bietet, um den Status der Aufgabe zu verwalten.

**Hinweis:**
Diese Aufgabe ist etwas anderst als die vorherigen. Hier bekommt ihr von mir die Program.Main Methode, sowie eine unvollständige Klasse vorgegeben. Eure Aufgabe ist es, ein neues C#-Projekt zu erstellen (Name: "Taskmaster"), die gegebene unvollständige Klasse zu vervollständigen (Eigenschaften, Methoden, Konstruktor) und mit meinem gegebenen Code die Klasse zu Testen.

**Aufgabenstellung:**

1. **Klasse vervollständigen:**
    - Die Klasse soll die folgenden Eigenschaften (Properties) haben:
        - `Title` (string)
        - `Description` (string)
        - `DueDate` (DateTime)
        - `IsCompleted` (bool)
    - Erstelle einen Konstruktor für die Klasse, der die oben genannten Eigenschaften initialisiert.

2. **Implementiere gegebene Methoden:**
    - Erstelle eine Methode `GetTaskInfo`, die eine Beschreibung der Aufgabe im folgenden Format zurückgibt:
      `"Title: {Title}, Beschreibung: {Description}, Fällig bis: {DueDate}, Erledigt: {IsCompleted}"`
    - Erstelle eine Methode `CompleteTask`, die den Status der Aufgabe auf erledigt (`IsCompleted = true`) setzt.
    - Erstelle eine Methode `ExtendDueDate`, die ein neues Fälligkeitsdatum (DateTime) als Parameter erhält und das Fälligkeitsdatum der Aufgabe entsprechend aktualisiert.

3. **Testen:**
    - Erstelle mehrere Instanzen der Klasse `Task` und rufe die Methoden `GetTaskInfo`, `CompleteTask` und `ExtendDueDate` für jede Instanz auf.
    - Gib die Ergebnisse in der Konsole aus.

**Gegebener Code:**

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Erstelle mehrere Aufgabenobjekte
        Task task1 = new Task("Dokumentation schreiben", "Schreibe die Projektdokumentation bis zum Ende der Woche", new DateTime(2024, 7, 7));
        Task task2 = new Task("Code-Review durchführen", "Überprüfe den Code des neuen Features", new DateTime(2024, 7, 5));

        // Rufe die Beschreibungen ab und gib sie aus
        Console.WriteLine(task1.GetTaskInfo());
        Console.WriteLine(task2.GetTaskInfo());

        // Markiere die erste Aufgabe als erledigt
        task1.CompleteTask();
        Console.WriteLine(task1.GetTaskInfo());

        // Verlängere das Fälligkeitsdatum der zweiten Aufgabe
        task2.ExtendDueDate(new DateTime(2024, 7, 10));
        Console.WriteLine(task2.GetTaskInfo());
    }
}
public class Task
{
    // Eigenschaften kommen hier hin:

    // Konstruktor soll hier implementiert werden:

    // Beschreibung der Aufgabe
    public string GetTaskInfo()
    {
    }

    // Markierung der Aufgabe als erledigt
    public void CompleteTask()
    {
    }

    // Verlängerung des Fälligkeitsdatums
    public void ExtendDueDate(DateTime newDueDate)
    {
    }
}
```
