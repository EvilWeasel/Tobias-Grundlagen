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
Console.WriteLine("Was möchtest du tun?");
Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen");

do
{
  var input = Console.ReadLine();

  switch (input)
  {
    case "1":
      // Option 1: Todo erstellen
      // Userintput nehmen
      var todo = Console.ReadLine();
      
      // Neues Todo zur Todoliste hinzufügen
      // Todo erstellen
      Console.WriteLine("CREATE");
      break;
    case "2":
      // Liste der Todos anzeigen
      Console.WriteLine("READ");
      break;
  }
} while (false);

