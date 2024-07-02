Console.WriteLine("Gebe eine Zahl ein:");
var input = Console.ReadLine();
// int index = Convert.ToInt32(input);
// int index = int.Parse(input);
bool error = int.TryParse(input, out int output);

if (!error)
{
  Console.WriteLine(error);
} else
{
  Console.WriteLine(output);
}
// Funktionsbezeichner (Namen) muss eindeutig sein!
// int getIndex()
// {
//   Console.WriteLine("Gebe etwas ein: ");
//   var input = Console.ReadLine();
//   var number = int.Parse(input);
//   return number;
// }

// Beispiel: Funktion/Methode mit Parameter
// Eine Funktion kann keinen, einen oder beliebig viele Parameter bekommen
// Die Parameter können die Funktionsweise einer Methode dynamisch ändern
int getIndex(string prompt) // Funktionssignatur
{
  Console.WriteLine(prompt);
  var input = Console.ReadLine();
  var number = int.Parse(input ?? "0");
  return number;
}

List<string> todos = new();

todos.Add("Wäsche waschen");
todos.Add("Bügeln");

// Die nächsten 2 Zeilen sind funktional identisch mit der dritten folgenden Zeile
// Console.WriteLine(""Gebe die Aufgabe ein, die du bearbeiten willst:"")
// int index = int.Parse(Console.ReadLine());
int index = getIndex("Gebe die Aufgabe ein, die du bearbeiten willst:");
// int my_second_index = getIndex("...einen anderen Text eingeben"); // kann beliebig oft aufgerufen werden
Console.WriteLine(todos[index]);

