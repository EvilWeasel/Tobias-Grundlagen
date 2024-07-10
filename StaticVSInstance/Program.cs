int numberInput1 = 0;
int numberInput2 = 0;
int result = 0;
do
{
  Console.Clear();
  Console.WriteLine("Was willst du rechnen?");
  Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide");
  var menuInput = Console.ReadLine();
  switch (menuInput)
  {
    case "1":
      Console.Write("Gebe die erste Zahl ein:\t");
      numberInput1 = int.Parse(Console.ReadLine());
      Console.Write("Gebe die zweite Zahl ein:\t");
      numberInput2 = int.Parse(Console.ReadLine());
      // var numberInput1 = Calculator.GetInput();
      result = numberInput1 + numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      break;
    case "2":
      Console.Write("Gebe die erste Zahl ein:\t");
      numberInput1 = int.Parse(Console.ReadLine());
      Console.Write("Gebe die zweite Zahl ein:\t");
      numberInput2 = int.Parse(Console.ReadLine());
      result = numberInput1 - numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      break;
    case "3":
      Console.Write("Gebe die erste Zahl ein:\t");
      numberInput1 = int.Parse(Console.ReadLine());
      Console.Write("Gebe die zweite Zahl ein:\t");
      numberInput2 = int.Parse(Console.ReadLine());
      result = numberInput1 * numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      break;
    case "4":
      Console.Write("Gebe die erste Zahl ein:\t");
      numberInput1 = int.Parse(Console.ReadLine());
      Console.Write("Gebe die zweite Zahl ein:\t");
      numberInput2 = int.Parse(Console.ReadLine());
      result = numberInput1 / numberInput2;
      Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
      Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
      Console.ReadKey();
      break;
  }
} while (true);

