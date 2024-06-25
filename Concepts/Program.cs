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
namen[99999999999999998] = "Buxtehude!";
Console.WriteLine(namen[0][0]);


// Array ist eine Liste an Werten
// Eine kontinuirliche Speicherregion, für mehrere Daten eines gewissen Types
int[] nums = new int[5];