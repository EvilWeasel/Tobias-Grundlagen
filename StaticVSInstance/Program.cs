using StaticVSInstance;

List<string> menuItems = new() 
{
  "Add",
  "Subtract",
  "Multiply",
  "Divide",
  "Dreieck Fläche",
  "Dreieck Umfang",
  "Kreis Fläche",
  "Kreis Umfang",
  "Rechteck Fläche",
  "Rechteck Umfang",
};

List<double> numberInputs = new();
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
  numberInputs.Clear();
  Calculator.PrintMenu(menuItems);
  var menuInput = Console.ReadLine();
  // numberInputs[10] = Calculator.GetNumberInput("Gebe die erste Zahl ein: "); geht nicht, weil nicht initialisiert. liste ist append only
  numberInputs.Add(Calculator.GetNumberInput("Gebe die erste Zahl ein: "));
  int menuInputIndex = int.Parse(menuInput);
  Operator op = (Operator)menuInputIndex;
  switch (op)
  {
    case Operator.Add:
      //Calculator.
      // var numberInput1 = Calculator.GetInput();
      numberInputs.Add(Calculator.GetNumberInput("Gebe die zweite Zahl ein: "));
      Calculator.Calculate(numberInputs, Operator.Add);
      break;
    case Operator.Subtract:
      numberInputs.Add(Calculator.GetNumberInput("Gebe die zweite Zahl ein: "));
      Calculator.Calculate(numberInputs, Operator.Subtract);
      break;
    case Operator.Multiply:
      numberInputs.Add(Calculator.GetNumberInput("Gebe die zweite Zahl ein: "));
      Calculator.Calculate(numberInputs, Operator.Multiply);
      break;
    case Operator.Divide:
      numberInputs.Add(Calculator.GetNumberInput("Gebe die zweite Zahl ein: "));
      Calculator.Calculate(numberInputs, Operator.Divide);
      break;
    case Operator.TriangleArea:
      numberInputs.Add(Calculator.GetNumberInput("Gebe die zweite Zahl ein: "));
      Calculator.Calculate(numberInputs, Operator.TriangleArea);
      break;
    case Operator.TriangleCircumference:
      numberInputs.Add(Calculator.GetNumberInput("Gebe die zweite Zahl ein: "));
      numberInputs.Add(Calculator.GetNumberInput("Gebe die dritte Zahl ein: "));
      Calculator.Calculate(numberInputs, Operator.TriangleCircumference);
      break;
    case Operator.CircleArea:
      Calculator.Calculate(numberInputs, Operator.CircleArea);
      break;
    case Operator.CircleCircumference:
      Calculator.Calculate(numberInputs, Operator.CircleCircumference);
      break;
    case Operator.RectangleArea:
      numberInputs.Add(Calculator.GetNumberInput("Gebe die zweite Zahl ein: "));
      Calculator.Calculate(numberInputs, Operator.RectangleArea);
      break;
    case Operator.RectangleCircumference:
      numberInputs.Add(Calculator.GetNumberInput("Gebe die zweite Zahl ein: "));
      Calculator.Calculate(numberInputs, Operator.RectangleCircumference);
      break;
  }

} while (true);

// void test() { } // Program.test() // auch eine Methode, weil gehört zur Program-Klasse