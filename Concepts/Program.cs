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

if(hamster.Contains("Max"))
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