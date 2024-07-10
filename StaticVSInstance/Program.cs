using StaticVSInstance;

int numberInput1 = 0;
int numberInput2 = 0;
int result = 0;

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

do
{
  Console.Clear();
  Console.WriteLine("Was willst du rechnen?");
  Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide");
  var menuInput = Console.ReadLine();
  switch (menuInput)
  {
    case "1":
      //Calculator.
      numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
      numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");
      // var numberInput1 = Calculator.GetInput();
      Calculator.Add(numberInput1, numberInput2);
      break;
    case "2":
      numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
      numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");
      Calculator.Subtract(numberInput1, numberInput2);
      break;
    case "3":
      numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
      numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");
      Calculator.Multiply(numberInput1, numberInput2);
      break;
    case "4":
      numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
      numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");
      Calculator.Divide(numberInput1, numberInput2);
      break;
  }

} while (true);

// void test() { } // Program.test() // auch eine Methode, weil gehört zur Program-Klasse