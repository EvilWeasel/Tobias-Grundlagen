using ExpensesTracker;

List<Expense> expenses = new();

do
{
  Console.WriteLine("---ExpensesTracker---");
  Console.WriteLine("Du hast folgende Expenses eingetragen:");
  foreach(Expense exp in expenses)
  {
    // Sollte "€" Anzeigen, Zeigt stattdessen "?"
    Console.WriteLine($"\t{exp.Name}: {exp.Price}€");
  }
  // Summe aller Expenses als Übersicht anzeigen
  Console.WriteLine("Was willst du tun?");
  Console.WriteLine("\t1. Neues Ausgabe angeben.");
  Console.WriteLine("\t2. Eine Ausgabe löschen.");
  var input = Console.ReadLine();
  switch (input)
  {
    case "1":
      Console.WriteLine("Wofür hast du Geld ausgegeben? (Expense-Name)");
      var name = Console.ReadLine();
      Console.WriteLine("Wie viel hast du ausgegeben? (eg. 420.69)");
      var price = Console.ReadLine();
      // Error-Checking: Was wenn User eine Zeichenkette (eg. "Buxtehude") eingibt?
      var decimalPrice = decimal.Parse(price);
      Console.WriteLine("In welche Kategorie willst du diese Expense einordnen?");
      var category = Console.ReadLine();
      var newExpense = new Expense(name, decimalPrice, category);
      expenses.Add(newExpense);
      Console.WriteLine("Du hast folgende Expense erstellt: ");
      Console.WriteLine($"\tname: {newExpense.Name}");
      Console.WriteLine($"\tprice: {newExpense.Price}");
      Console.WriteLine($"\tCategory: {newExpense.Category}");
      break;
    case "2":
      // Entfernen einer falsch-eingetragenen Expense
      Console.WriteLine("entfernen");
      break;
  }
  Thread.Sleep(2000);
  Console.Clear();
} while (true);
