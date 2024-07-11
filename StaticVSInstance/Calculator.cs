namespace StaticVSInstance
{
  public static class Calculator
  {
    /* Properties
    public string Title { get; set; }
    public double InstanceCount { get; set; }
    public string Title { get; set; }
    */
    public static double Count { get; set; }

    // Methoden
    public static double GetNumberInput(string inputPrompt) // Funktionssignatur -> Methodensignatur
    { // Function-Body -> Funktionskörper
      Console.Write(inputPrompt);
      return double.Parse(Console.ReadLine());
    }

    /* Calculate()
    Refactoring -> Umschreiben vom Code zum Verbessern der Performance, Lesbarkeit oder auch Wartbarkeit */
    public static double Calculate(double[] numberInputs, Operator op) 
    {
      double result = 0;
      Count++;
      Console.ForegroundColor = ConsoleColor.Magenta;
      switch (op)
      {
        case Operator.Add:
          result = numberInputs[0] + numberInputs[1];
          Console.WriteLine($"Das Ergebnis von {numberInputs[0]} + {numberInputs[1]} = {result}");
          break;
        case Operator.Subtract:
          result = numberInputs[0] - numberInputs[1];
          Console.WriteLine($"Das Ergebnis von {numberInputs[0]} - {numberInputs[1]} = {result}");
          break;
        case Operator.Multiply:
          result = numberInputs[0] * numberInputs[1];
          Console.WriteLine($"Das Ergebnis von {numberInputs[0]} * {numberInputs[1]} = {result}");
          break;
        case Operator.Divide:
          result = numberInputs[0] / numberInputs[1];
          Console.WriteLine($"Das Ergebnis von {numberInputs[0]} / {numberInputs[1]} = {result}");
          break;
        case Operator.AreaTriangle:
          result = AreaTriangle(numberInputs[0], numberInputs[1]);
          Console.WriteLine($"Das Dreieck {numberInputs.ToString()} ist {result} groß.");
          break;
        case Operator.CircumferenceTriangle:
          result = CircumferenceTriangle(numberInputs[0], numberInputs[1], numberInputs[2]);
          Console.WriteLine($"Die Fläche des Dreiecks {numberInputs.ToString()} ist {result} groß.");
          break;
      }
      Console.ResetColor();
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static double AreaTriangle(double baseLength, double height)
    {
      return 0.5 * baseLength * height;
    }
    public static double CircumferenceTriangle(double a, double b, double c)
    {
      return a + b + c;
    }

    public static double Add(double numberInput1, double numberInput2)
    {
      Count++;
      var result = numberInput1 + numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static double Subtract(double numberInput1, double numberInput2) 
    {
      Count++;
      var result = numberInput1 - numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static double Multiply(double numberInput1, double numberInput2)
    {
      Count++;
      var result = numberInput1 * numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
      Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      return result;
    }

    public static double Divide(double numberInput1, double numberInput2)
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
  public enum Operator
  {
    Add = 1,
    Subtract,
    Multiply,
    Divide,
    AreaTriangle,
    CircumferenceTriangle
  }
}