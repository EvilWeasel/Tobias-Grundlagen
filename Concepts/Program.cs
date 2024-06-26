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

var greeting =  GetGreeting();

Console.WriteLine(greeting);

// Chararrays
var my_array = "Feierabend!";
var my_letter = my_array[0];

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
Console.WriteLine(my_cool_variable);


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