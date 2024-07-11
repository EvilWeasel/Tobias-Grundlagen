using StaticVSInstance;

int numberInput1 = 0;
int numberInput2 = 0;
int result = 0;
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
  Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide");
  var menuInput = Console.ReadLine();
  numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
  numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");
  int menuInputIndex = int.Parse(menuInput);
  Operator op = (Operator)menuInputIndex;
  switch (op)
  {
    case Operator.Add:
      //Calculator.
      // var numberInput1 = Calculator.GetInput();
      Calculator.Calculate(numberInput1, numberInput2, Operator.Add);
      break;
    case Operator.Subtract:
      Calculator.Calculate(numberInput1, numberInput2, Operator.Subtract);
      break;
    case Operator.Multiply:
      Calculator.Calculate(numberInput1, numberInput2, Operator.Multiply);
      break;
    case Operator.Divide:
      Calculator.Calculate(numberInput1, numberInput2, Operator.Divide);
      break;
  }

} while (true);

// void test() { } // Program.test() // auch eine Methode, weil gehört zur Program-Klasse