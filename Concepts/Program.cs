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



// Funktionen
// x = 5y
var x = Console.WriteLine("buxtehude");
var y = Console.ReadLine();

var x = name.Trim();

//Console.WriteLine(x);

var test = 5.5;

// implicit conversion
Console.WriteLine((int)test + (int)test);

// explicit conversion
int num = int.Parse(test);