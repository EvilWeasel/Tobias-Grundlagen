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

using TD;

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
  if (Todo.Todos.Count >= 2)
    Console.WriteLine("Du hast folgende Aufgaben:");
  else if (Todo.Todos.Count == 0)
    Console.WriteLine("Du hast keine Aufgaben. Feierabend?:");
  else
    Console.WriteLine("Du hast folgende Aufgabe:");

  for (int i = 0; i < Todo.Todos.Count; i++)
  {
    Console.WriteLine($"{i}. {Todo.Todos[i]}");
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

Todo.DeserializeAll();

// Console.WriteLine(todos.Count); // Ausgabe ist die Kapazität, also 20

// das hier ist aktuell noch null!!!
// Console.WriteLine(todos[9]);
// "Buxtehude", 12-7-24, false
// "buxtehude2", 12-7-24, false
do
{
  Console.Clear();
  Console.WriteLine("Was möchtest du tun?");
  Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen\n\t3. Todo abhacken\n\t4. Todo überschreiben");
  var menuInput = Console.ReadLine();

  switch (menuInput)
  {
    case "1":
      Console.WriteLine("Was hast du zu tun? <Enter zum bestätigen>");
      var todoInput = Console.ReadLine();

      // Fügen wir das Todo hinzu
      Todo newTodo = new Todo(todoInput);
      Todo.Todos.Add(newTodo);
      Console.WriteLine("Todo hinzugefügt:\n" + newTodo);
      // Lässt den aktuellen Prozess schlafen.
      Todo.SerializeAll();
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
      Todo todoToRemove = Todo.Todos[todoIndex];
      // lösche todo
      Todo.Todos[todoIndex].IsComplete = true;
      // zeige gelöschtes todo dem user
      Todo.SerializeAll();
      Console.WriteLine($"Todo erledigt:\n{todoToRemove}");
      showTodos();
      break;
    case "4":
      // Updaten/Verändern eines Todos (verändern des strings)
      printTodos();
      var index = getIndex("Welches Todo möchtest du anpassen?");

      Console.WriteLine("Was möchtest du stattdessen tun?");
      string newText = Console.ReadLine();

      Todo.Todos[index].Title = newText;
      Todo.SerializeAll();
      Console.WriteLine("Text verändert: " + Todo.Todos[index]);
      showTodos();
      break;
  }
} while (true);
