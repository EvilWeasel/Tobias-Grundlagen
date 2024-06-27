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

// Menü anzeigen mit Optionen
Console.WriteLine("Willkommen bei TD!");

List<string> todos = new();

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
      break;
    case "2":
      Console.WriteLine("Du hast folgende Aufgaben:");
      for (int i = 0; i < todos.Count; i++)
      {
        Console.WriteLine($"\t{i}. {todos[i]}");
      }
      Console.WriteLine("Drücke <ENTER> um zurück ins Menü zu kommen.");
      Console.ReadKey();
      break;
    case "3":
      // Löschen
      Console.WriteLine("Welches Todo möchtest du löschen?");
      for (int i = 0; i < todos.Count; i++)
      {
        Console.WriteLine($"\t{i}. {todos[i]}");
      }
      var todoIndexString = Console.ReadLine();
      int todoIndex = int.Parse(todoIndexString);
      todos.RemoveAt(todoIndex);
      break;
    case "4":
      // Updaten/Verändern eines Todos (verändern des strings)
      Console.WriteLine("Welches Todo möchtest du anpassen?");
      for (int i = 0; i < todos.Count; i++)
      {
        Console.WriteLine($"\t{i}. {todos[i]}");
      }
      var indexString = Console.ReadLine();
      int index = int.Parse(indexString);

      Console.WriteLine("Was möchtest du stattdessen tun?");
      var newTodo = Console.ReadLine();
      todos[index] = newTodo;
      break;
  }
} while (true);

