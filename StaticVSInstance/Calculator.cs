namespace StaticVSInstance
{
  public static class Calculator
  {
    // Properties
    // public string Title { get; set; }
    // public int InstanceCount { get; set; }
    public static int Count { get; set; }
    // public string Title { get; set; }

    // Methoden
    public static int GetNumberInput(string inputPrompt) // Funktionssignatur -> Methodensignatur
    { // Function-Body -> Funktionskörper
      Console.Write(inputPrompt);
      return int.Parse(Console.ReadLine());
    }

    // Calculate()
    // Refactoring -> Umschreiben vom Code zum Verbessern der Performance, Lesbarkeit oder auch Wartbarkeit
    public static int Calculate(int numberInput1, int numberInput2, string op) 
    {
      int result = 0;
      Count++;
      if (op == "+")
      {
        result = numberInput1 + numberInput2;
        Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
      }
      else if (op == "-")
      {
        result = numberInput1 - numberInput2;
        Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
      }
      else if (op == "*") 
      {
        result = numberInput1 * numberInput2;
        Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
      } else
      {
        result = numberInput1 / numberInput2;
        Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
      }

      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static int Add(int numberInput1, int numberInput2)
    {
      Count++;
      var result = numberInput1 + numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static int Subtract(int numberInput1, int numberInput2) 
    {
      Count++;
      var result = numberInput1 - numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static int Multiply(int numberInput1, int numberInput2)
    {
      Count++;
      var result = numberInput1 * numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static int Divide(int numberInput1, int numberInput2)
    {
      Count++;
      var result = numberInput1 / numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }
    /// <summary>
    /// Das hier ist wie Add(), aber wird über die Instanz der Klasse (konkretes Objekt eg. "calc1.AddInstance") aufgerufen. Der InstanceCount ist für jede Instanz (Objekt) unterschiedlich (eg. calc1.InstanceCount != calc2.InstanceCount)
    /// </summary>
    /// <param name="numberInput1"></param>
    /// <param name="numberInput2"></param>
    /// <returns></returns>
    /*
    public int AddInstance(int numberInput1, int numberInput2)
    {
      InstanceCount++;
      var result = numberInput1 + numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
      return result;
    }
    */
  }
}
