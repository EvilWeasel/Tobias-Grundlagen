namespace old_template
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<string> todos = new List<string>();
      printTodos();
    }
    static int getIndex(string prompt) // Funktionssignatur
    {
      Console.WriteLine(prompt);
      var input = Console.ReadLine();
      var number = int.Parse(input ?? "0");
      return number;
    }

    static void printTodos()
    {
      Console.WriteLine("Du hast folgende Aufgaben:");
      // folgender code wirft fehler, weil todos innerhalb dieser funktion nicht existiert.
      // todos ist innerhalb von Program.Main definiert
      // for (int i = 0; i < todos.Count; i++)
      // {
      //   Console.WriteLine($"\t{i}. {todos[i]}");
      // }
    }
  }
}
