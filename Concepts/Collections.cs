using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
  internal class Collections
  {
    internal void ArraysRun()
    {
      // Chararrays
      var my_array = "Feierabend!";
      // speicher wird zur deklaration reserviert
      var my_letter = my_array[99999999]; // speicher weg

      // Collections-Basics
      // Array
      string[] namen = new string[5];
      string[] alternative_namen = ["Tobi", "Popstar", "Lehrer"]; // max 3 items
      string[] alternative_namen1 = { "Ab", "Bc", "Cd" };
      namen[0] = "Tobi";
      namen[1] = "Melanie";
      namen[2] = "Torben";
      // namen[99999999999999998] = "Buxtehude!";
      Console.WriteLine(namen[0][0]);

      int increment_me = 0;
      // Die folgenden 2 Zeilen sind syntaktisch gleich
      increment_me = increment_me + 1;
      increment_me += 1;
      // increment-operator
      increment_me++;
      Console.WriteLine("Increment me is: ");
      Console.WriteLine(increment_me);
      // String-Interpolation
      // Hat einige Nachteile, was Sicherheit angeht (s. Vertiefung)
      Console.WriteLine($"Increment me is: {increment_me}");


      // Array ist eine Liste an Werten
      // Eine kontinuirliche Speicherregion, für mehrere Daten eines gewissen Types
      // Ein Array hat immer eine feste Größe, welche bei der Initialisierung festgelegt werden muss
      // Array.Length ist immer die maximale Länge des Arrays
      int[] nums = new int[5];
      nums[0] = 10;
      /*
       For Loop - 4 Komponenten
         1. Deklaration der Zählervariablen
         2. Bedingung der Schleife (Wann zu Ende?)
         3. Operation, welche nach jeder Iteration ausgeführt wird
            -> idr. Inkrement (i++) oder Dekrement (i--)
         4. Codeblock, welcher definiert, was bei jeder iteration der Schleife passieren soll.
       */
      for (int i = 0; i < nums.Length; i++)
      {
        Console.WriteLine(nums[i]);
      }

      int test_me = 0;

      // Variablen, welche innerhalb eines Blocks deklariert sind,
      //   können nicht außerhalb dieses Blocks verwendet werden.
      {
        Console.WriteLine(test_me);
        int my_cool_variable = 0;
        Console.WriteLine(my_cool_variable);
        {
          Console.WriteLine(my_cool_variable);
        }
      }
      // Console.WriteLine(my_cool_variable); # Crash! Variable existiert nicht im Kontext


      /*
      {
        var myvar1 = 0;
      }
      {
        var myvar1 = 10;
      }
      var myvar2 = 10;
      var myvar2 = 20;
      Console.WriteLine(myvar1);
      */
    }
    internal void ListRun()
    {
      // Deklaration & Initialisierung
      // string[] namen = new string[20];
      // Deklaration
      string[] namen = new string[2];

      namen[0] = "Tobi";
      namen[1] = "Susanne";
      // namen[2] = "Markus";

      namen = namen.Append("Markus").ToArray();
      // weil voll, geht nicht -> passiert was, aber nicht das was wir denken was passieren sollte...

      for (int i = 0; i < namen.Length; i++)
      {
        Console.WriteLine(namen[i]);
      }
      string[] test_array = { "test", "me" };
      Console.WriteLine(test_array); // string[]

      //// Listen
      Console.WriteLine("---Listen---");

      // List<string> hamster = new List<string>();
      //   var hamster = new List<string>();
      List<string> hamster = new();
      Console.WriteLine(hamster);

      // Hinzufügen am Ende
      hamster.Add("Max"); // index 0
      hamster.Add("Erika"); // index 1

      // Hinzufügen an gewissen Index
      hamster.Insert(1, "Fabian");

      Console.WriteLine(hamster[0]);

      // Löschen eines Elements => Angabe des Elements (nicht der Index)
      hamster.Remove("Fabian");

      Console.WriteLine(hamster[1]);

      // Löschen des letzten Elements
      // hamster.RemoveAt(hamster.Count - 1);

      hamster.Add("Melanie");

      if (hamster.Contains("Max"))
      {
        // mach was cooles...
      }
      // Anders als beim Array:
      // Liste hat Count, statt Länge!
      // Count ist die aktuelle größe der Liste
      // Length ist die Gesamtkapazität des Arrays
      // ps: Liste hat eine Kapazität, aber für uns nicht relevant -> hamster.Capacity
      Console.WriteLine(hamster.Count);

      for (int index = 0; index < hamster.Count; index++)
      {
        Console.WriteLine(hamster[index]);
      }
    }
  }
}
