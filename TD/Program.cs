/* Program-Einstiegspunkt C#
 * namespace TD
{
  // Programmeinstiegspunkt (Wo das Programm anfängt auszuführen.)
  // => Program.Main
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      Console.ReadLine();
      // hier...
      var x = Start();
      Console.WriteLine(x);
    }
    static string Start()
    {
      Console.WriteLine("Buxtehude!");
      return "blubb";
    }
    // const login = function() {...}
    // login()
  }
}
*/

// Erstelle eine Funktion, für die Ausgabelogik der Liste

List<string> todos = new();

int getIndex(string prompt) // Funktionssignatur
{
  Console.WriteLine(prompt);
  var input = Console.ReadLine();
  var number = int.Parse(input);
  return number;
}

void printTodos()
{
  // Wenn nur eine einzige Anweisung auf ein if-/else Statement folgt, kann man die curly-braces {} weglassen
  if (todos.Count >= 2)
    Console.WriteLine("Du hast folgende Aufgaben:");
  else if (todos.Count == 0)
    Console.WriteLine("Du hast keine Aufgaben. Feierabend?:");
  else
    Console.WriteLine("Du hast folgende Aufgabe:");

  for (int i = 0; i < todos.Count; i++)
  {
    Console.WriteLine($"\t{i}. {todos[i]}");
  }
}

void showTodos()
{
  printTodos();
  Console.WriteLine("Drücke <ENTER> um zurück ins Menü zu kommen.");
  Console.ReadKey();
}

// Menü anzeigen mit Optionen
Console.WriteLine("Willkommen bei TD!");


// Console.WriteLine(todos.Count); // Ausgabe ist die Kapazität, also 20

// das hier ist aktuell noch null!!!
// Console.WriteLine(todos[9]);

do
{
  Console.Clear();
  Console.WriteLine("Was möchtest du tun?");
  Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen\n\t3. Todo abhacken\n\t4. Todo überschreiben");
  var input = Console.ReadLine();

  switch (input)
  {
    case "1":
      Console.WriteLine("Was hast du zu tun? <Enter zum bestätigen>");
      var todo = Console.ReadLine();

      // Fügen wir das Todo hinzu
      todos.Add(todo);
      Console.WriteLine("Todo hinzugefügt: " + todo);
      // Lässt den aktuellen Prozess schlafen.
      Thread.Sleep(2000); // 2 Sekunden delay für Ansicht
      // Console.ReadLine(); // User entscheidet länge der Pause
      break;
    case "2":
      showTodos();
      break;
    case "3":
      // Löschen
      printTodos();
      var todoIndex = getIndex("Welches Todo möchtest du löschen?");
      // todos.Remove("Bei Penny einkaufen gehen.");

      // hole todo, vor dem löschen, zum anzeigen
      string todoToRemove = todos[todoIndex];
      // lösche todo
      todos.RemoveAt(todoIndex);
      // zeige gelöschtes todo dem user
      Console.WriteLine($"GELÖSCHT: {todoToRemove}");
      showTodos();
      break;
    case "4":
      // Updaten/Verändern eines Todos (verändern des strings)
      printTodos();
      var index = getIndex("Welches Todo möchtest du anpassen?");

      Console.WriteLine("Was möchtest du stattdessen tun?");
      var newTodo = Console.ReadLine();
      todos[index] = newTodo;

      Console.WriteLine("Text verändert: " + newTodo);
      showTodos();
      break;
  }
} while (true);

