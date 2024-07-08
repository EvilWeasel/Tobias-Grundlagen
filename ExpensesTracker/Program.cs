using ExpensesTracker;

do
{
  Console.WriteLine("---ExpensesTracker---");
  Console.WriteLine("Was willst du tun?");
  Console.WriteLine("\t1. Neues Ausgabe angeben.");
  Console.WriteLine("\t2. Eine Ausgabe löschen.");
  var input = Console.ReadLine();
  switch (input)
  {
    case "1":
      Console.WriteLine("neu");
      Console.WriteLine("Wofür hast du Geld ausgegeben? (Expense-Name)");
      var name = Console.ReadLine();
      Console.WriteLine("Wie viel hast du ausgegeben? (eg. 420.69)");
      var price = Console.ReadLine();
      var decimalPrice = decimal.Parse(price);
      Console.WriteLine("In welche Kategorie willst du diese Expense einordnen?");
      var category = Console.ReadLine();
      var newExpense = new Expense(name, decimalPrice, category);
      Console.WriteLine("Du hast folgende Expense erstellt: ");
      Console.WriteLine($"\tname: {newExpense.Name}");
      Console.WriteLine($"\tprice: {newExpense.Price}");
      Console.WriteLine($"\tCategory: {newExpense.Category}");
      Console.ReadKey();
      break;
    case "2":
      Console.WriteLine("entfernen");
      break;
  }
  Thread.Sleep(2000);
  Console.Clear();
} while (true);
