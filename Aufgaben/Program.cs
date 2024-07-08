// Der ganze Code in dieser Datei ist in der Program.Main Funktion.
using Aufgaben;

/*

// Kommt aus Example.Test -> Example.cs file
Example.Test();

// Was wenn diese Liste hier einen Count von 1.000.000+ hat?
List<int> numbers = new(){ 1, 2, 3, 4, 5, 6, 7 };
List<int> numbers_even = new(){ 1, 2, 3, 4, 5, 6 };
int query = 6;

// Aufgabe: Find Index
var index = Sammlungen.FindIndex(numbers, query); // wenn query 6, sollte index = 5
Console.WriteLine($"FindIndex Test1; Sollte 5; Ist {index}"); // sollte 5 sein
// Find Index mit 1.000.000 Elementen in Liste
var manyNumbers = Sammlungen.GenerateNumbers(1_000_000_000);
var manyNumbersQuery = 999_999_999;
Console.WriteLine(manyNumbers.Count);
var manyNumbersIndex = Sammlungen.FindIndexAlt(manyNumbers, manyNumbersQuery);
Console.WriteLine($"FindIndex ManyNumbers SLOW; Sollte 999_999_999; Ist {manyNumbersIndex}"); // sollte 5 sein

var manyNumberFastIndex = Sammlungen.FindIndexOptimized(manyNumbers, manyNumbersQuery);
Console.WriteLine($"FindIndex ManyNumbers FAST; Sollte 999_999_999; Ist {manyNumberFastIndex}"); // sollte 5 sein

*/


List<int> temperatures = new() { 20, 22, 19, 24, 21, 18, 25 };
// Folgende Zeile ruft einen Index außerhalb des Arrays (Range) auf
// var x = temperatures[69]; // Runtime-Error
var tempLimit = 21;
List<int> aboveIndices = Temperature.AboveMin(temperatures, tempLimit);

aboveIndices.ForEach(Console.WriteLine); // sollte index [1,3,6] sein


// Temperature Average

var averageTemp = Temperature.Average(temperatures);
Console.WriteLine($"Average: {averageTemp}"); // sollte 21.285714285714285 sein


Sammlungen.BaumBauer();

var minTemp = Sammlungen.FindSmallestValue(temperatures.ToArray());
Console.WriteLine(minTemp);

var unsortedNums = new int[]{1, 2, 3, 4, 5, 6};
var evenNums = Sammlungen.OnlyEven(unsortedNums.ToList());
evenNums.ForEach(Console.Write);

Console.WriteLine();

// Console.WriteLine("   oma    opa   ".Replace("  ", " "));

var printMeBackwards = "   Barry B.           Benson        ";
// Console.Write in der Funktion
StringAufgaben.PrintBackwards(printMeBackwards);

var wordCount = StringAufgaben.CountWords(printMeBackwards);
Console.WriteLine($"Count of {printMeBackwards}: " + wordCount);
Console.WriteLine();

var countLastWord = "Barry B. Bensona";
var countOfBenson = StringAufgaben.CountCharsOfLastWordInText(countLastWord);
Console.WriteLine($"{countLastWord.Split(' ').Last()} is {countOfBenson}");
Console.WriteLine(countLastWord.ToUpper());

Console.WriteLine("---CountVokaleUndKonsonanten---");
StringAufgaben.PrintConsonantAndVowels("buxtehude");