using StaticVSInstance;
double[] numberInputs = new double[3];
double result = 0;
/*

Calculator c = new Calculator();
c.GetNumberInput("test");

Calculator c2 = new Calculator();
c2.GetNumberInput("dksfj");
c2.Count
*/
/*
Calculator mixed = new Calculator();
mixed.Title = "Hexenwerk!";
*/
// Wenn wir die Methoden des Taschenrechners statisch machen, müssen wir keine Instanz (Objekt) der Klasse Calculator (eg. var calc = new Calculator()) erstellen.
/*
Calculator calculator = new Calculator();
calculator.Title = "Mein cooler Taschenrechner";
Calculator.Title = "Geht nicht, weil keine Instanz.";
calculator.Count = "Gibt es nicht auf der Instanz...";
Calculator.Count = 10;

calculator.Add(10,20);

Calculator calculator1 = new Calculator();
calculator1.Add(20, 30);

Calculator calc1 = new Calculator();
Calculator calcSubtract = new Calculator();

*/

/*
 Beispiel für einen Datentyp (Klasse) mit statischen- und Instanzmembern. Member => Property, Methods, private Fields
 */
int x = 0;
x.ToString();
var parsed = int.Parse("1");

do
{
  Console.Clear();
  Console.WriteLine("Was willst du rechnen?");
  Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide\n\t5.Triangle Area\n\t6.Triangle Circumference");
  var menuInput = Console.ReadLine();
  numberInputs[0] = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
  numberInputs[1] = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");
  int menuInputIndex = int.Parse(menuInput);
  Operator op = (Operator)menuInputIndex;
  switch (op)
  {
    case Operator.Add:
      //Calculator.
      // var numberInput1 = Calculator.GetInput();
      Calculator.Calculate(numberInputs, Operator.Add);
      break;
    case Operator.Subtract:
      Calculator.Calculate(numberInputs, Operator.Subtract);
      break;
    case Operator.Multiply:
      Calculator.Calculate(numberInputs, Operator.Multiply);
      break;
    case Operator.Divide:
      Calculator.Calculate(numberInputs, Operator.Divide);
      break;
    case Operator.AreaTriangle:
      Calculator.Calculate(numberInputs, Operator.AreaTriangle);
      break;
    case Operator.CircumferenceTriangle:
      numberInputs[2] = Calculator.GetNumberInput("Gebe die dritte Zahl ein: ");
      Calculator.Calculate(numberInputs, Operator.CircumferenceTriangle);
      break;
  }

} while (true);

// void test() { } // Program.test() // auch eine Methode, weil gehört zur Program-Klasse