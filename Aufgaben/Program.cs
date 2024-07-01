// Der ganze Code in dieser Datei ist in der Program.Main Funktion.
using Aufgaben;

// Kommt aus Example.Test -> Example.cs file
Example.Test();

// Was wenn diese Liste hier einen Count von 1.000.000+ hat?
List<int> numbers = new(){ 1, 2, 3, 4, 5, 6, 7 };
int query = 6;

// Aufgabe: Find Index
var index = Sammlungen.FindIndex(numbers, query); // wenn query 6, sollte index = 5
Console.WriteLine(index); // sollte 5 sein

Temperature.Test();