namespace old_template
{
  internal class Program
  {
    static void Main(string[] args)
    {
      
      getIndex("teststst");
      
    }
    static int getIndex(string prompt) // Funktionssignatur
    {
      Console.WriteLine(prompt);
      var input = Console.ReadLine();
      var number = int.Parse(input);
      return number;
    }
  }
}
