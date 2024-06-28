Console.WriteLine("Gebe eine Zahl ein:");
var input = Console.ReadLine();
// int index = Convert.ToInt32(input);
// int index = int.Parse(input);
bool error = int.TryParse(input, out int index);

if (!error)
{
  Console.WriteLine(error);
} else
{
  Console.WriteLine(index);
}


int getIndex()
{
  Console.WriteLine("Gebe die Aufgabe ein, die du bearbeiten willst:");
  var input = Console.ReadLine();
  var number = int.Parse(input);
  return number;
}

string[] my_todos = ["Wäsche waschen", "Bügeln"];

int my_index = getIndex();
// int my_second_index = getIndex(); // kann beliebig oft aufgerufen werden
// Console.WriteLine(my_todos[my_index]);