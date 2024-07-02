// Der ganze Code in dieser Datei ist in der Program.Main Funktion.
using Aufgaben;

// Kommt aus Example.Test -> Example.cs file
Example.Test();

// Was wenn diese Liste hier einen Count von 1.000.000+ hat?
List<int> numbers = new(){ 1, 2, 3, 4, 5, 6, 7 };
int query = 6;

// Aufgabe: Find Index
var index = Sammlungen.FindIndex(numbers, query); // wenn query 6, sollte index = 5
Console.WriteLine($"FindIndex Test1; Sollte 5; Ist {index}"); // sollte 5 sein
// Find Index mit 1.000.000 Elementen in Liste
var manyNumbers = Sammlungen.GenerateNumbers(1_000_000_000);
var manyNumbersQuery = 999_999_999;
Console.WriteLine(manyNumbers.Count);
var manyNumbersIndex = Sammlungen.FindIndexAlt(manyNumbers, manyNumbersQuery);
Console.WriteLine($"FindIndex ManyNumbers; Sollte 999_999_999; Ist {manyNumbersIndex}"); // sollte 5 sein






List<int> temperatures = new() { 20, 22, 19, 24, 21, 18, 25 };
var tempLimit = 21;
List<int> aboveIndices = Temperature.AboveMin(temperatures, tempLimit);

aboveIndices.ForEach(Console.WriteLine); // sollte index [1,3,6] sein


// Temperature Average

var averageTemp = Temperature.Average(temperatures);
Console.WriteLine($"Average: {averageTemp}"); // sollte 21.285714285714285 sein
