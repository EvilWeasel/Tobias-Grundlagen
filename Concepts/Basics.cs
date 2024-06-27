namespace Concepts
{
  internal class Basics
  {
    internal void Run()
    {
      string name = "tobi";
      /*
       PascalCase => WorttrennungenWerdenGrossGeschrieben
        camelCase => worttrennungenWerdenKleingeschrieben
        snake_case => worttrennungen_werden_kleingeschrieben
        kebab-case => worttrennungen-werden-kleingeschrieben
       */

      /*
       DateTime ist einer von vielen komplexen Datentypen in C#.
        DateTime ist ein Strukturtyp, der Datum und Uhrzeit darstellt.
        Komplexe DatenTypen sind Objekte, die aus mehreren Werten bestehen, welche
          ebenfalls komplex oder auch primitv sein können.
         Objekte können nur in der Konsole ausgegeben werden, wenn sie eine Methode
          ToString() haben.
       */
      DateTime date = DateTime.Now;
      Console.WriteLine(date.Year);

      Console.WriteLine(name);


      bool is_true = false;
      // Funktionen
      // x = 5y

      string? test_null = null;
      Console.WriteLine("buxtehude");
      //
      // var y = Console.ReadLine();

      var trimmed_name = name.Trim();

      //Console.WriteLine(x);

      var test = 5.5;

      // implicit conversion
      Console.WriteLine((int)test + (int)test);

      // explicit conversion
      // int num = int.Parse(test);

      void PrintName()
      {
        Console.WriteLine("Hello World!");
      }
      /*
       * JavaScript
       function printName() {
        console.log("Hello World!");
       }
       * Python
       def printName():
         print("Hello World!")
       # hier gehts dann weiter
       */

      PrintName();
      PrintName();

      string GetGreeting()
      {
        return "Herzlich Willkommen!";
      }

      var greeting = GetGreeting();

      Console.WriteLine(greeting);
    }
  }
}
