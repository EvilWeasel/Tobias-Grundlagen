namespace _07Schleifen
{
    internal class Program
    {
#pragma warning disable CS0219 // Unnecessary assignment of a value
#pragma warning disable CS0168 // Unnecessary assignment of a value
#pragma warning disable CS8600 // Unnecessary assignment of a value
    static void Main(string[] args)
        {
            //while-Schleife - die kopfgesteuerte Schleife
            //Syntax:
            //while(<kondition>)
            //{ }

            //int zaehler = 0;
            //while (true ) //SOLANGE die Kondition wahr ist: 
            //{ //führe folgenden Code aus:
            //    Console.Clear();
            //    Console.WriteLine(zaehler);
            //    zaehler++;

            //    //Die folgende Codezeile hat nichts mit Schleife
            //    //Sie lässt die Anweisung für 1000ms pausieren damit wir sehen können wie Zähler zählt.
            //    Thread.Sleep(1000);


            //}

            bool exit = false;
            //while (exit == false)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Kopfgesteuert");
            //    Console.Write("Hey User bitte gebe deinen Namen ein: ");
            //    string username = Console.ReadLine();
            //    Console.WriteLine($"Hallo {username}");
            //    Console.WriteLine($"{username}, gib E(x)it ein um das Programm zu beenden: ");
            //    string eingabe = Console.ReadLine();
            //    eingabe = eingabe.Trim(); //.Trim() macht zum Beispiel aus "Hello World      " --> "Hello World"
            //    eingabe = eingabe.ToLower();// .ToLower macht zum Beispiel aus "HELLO World" --> "hello world"

            //    if(eingabe == "exit" || eingabe == "x")
            //    {
            //        exit = true;
            //    }
            //}

            //do-while-Schleife - fußgesteuerte Schleife
            //Syntax:
            //do
            //{}
            //while(<kondition>)

            //do//mache folgendes
            //{
            //    Console.Clear();
            //    Console.WriteLine("Fußgesteuert");
            //    Console.WriteLine("Hallo User gib deinen Namen ein");
            //    string username = Console.ReadLine();
            //    Console.WriteLine($"Hallo {username}");
            //    Console.Write($"{username} gib E(x)it ein um das Programm zu beenden ");
            //    string eingabe = Console.ReadLine().ToLower().Trim();
            //    if (eingabe == "exit" || eingabe == "x")
            //    {
            //        exit = true;
            //    }
            //}
            //while (false == false); //SOLANGE diese Kondition wahr ist.

            //Zählergesteuerte Schleife

            //int i = 0; ;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Aufgabe 1

            //Erstellen Sie einen einfachen Taschenrechner.
            //Der User soll nacheinander zwei Zahlen und auch  
            //ein Zeichen für die Rechenart eingeben können (+ - * / ) können.
            //Anschließend wird die Berechnung durchgeführt und das Ergebnis ausgegeben.
            //Nach Ausgabe des Ergebnis fragen Sie den User ob er eine weitere Berechnung durchführen möchte oder
            //ob er das Programm verlassen will.

            double zahl1, zahl2;
            double ergebnis = 0;
            string rechenart;
            bool wiederholung = false;
            bool operatorOk = true;

            do 
            { 
                Console.Clear();
                Console.WriteLine("User gib die erste Zahl ein: ");
                zahl1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("User gib bitte die zweite Zahl ein: ");
                zahl2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("User gib nun die Art der Berechnung an: Es stehen + - * / zur verfügung: ");
                rechenart = Console.ReadLine();

                switch (rechenart)
                {
                    case "+":
                        ergebnis = zahl1 + zahl2;
                        break;
                    case "-":
                        ergebnis = zahl1 - zahl2;
                        break;
                    case "*":
                        ergebnis = zahl1 * zahl2;
                        break;
                    case "/":
                        ergebnis = zahl1 / zahl2;
                        break;
                    default:
                        Console.WriteLine("Ungültiger Operator. Bitte wähle  + - * / aus.");
                        operatorOk = false;
                        break;
                }
                if (operatorOk) Console.WriteLine($"{zahl1} {rechenart} {zahl2} = {ergebnis}");

                Console.WriteLine("Möchtest du eine weitere Rechnung ausführen? j/n");
                string eingabe = Console.ReadLine()?.ToLower().Trim();
                wiederholung = eingabe == "j"; 
            }while (wiederholung);


        }
    }
}
