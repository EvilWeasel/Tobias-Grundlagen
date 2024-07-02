using System.Security;

namespace _06Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[]-Operator: Index-operator
            string hello = "Hallo Welt";
            char zeichen1 = hello[0]; //Index 0 ist das erste Zeichen der zeichenkette -> H
            char zeichen2 = hello[1]; //Hier ist der Wert 'a' das zweite Zeichen der Zeichenkette.
            char zeichen3 = hello[5]; // Hier ist der Wert ' ' , das Leerzeichen.

            //string text = Console.ReadLine(); // Wir speichern einen Text in den String "text" über die Konsole mit .Readline()
            //char letztesZeichenVonText = text[text.Length-1];  // von textermitteln wir das letzte Zeichen in dem wir .Length benutzen um die anzahl
            // an Zeichen zu erhalten und ziehen 1 ab um den richtigen Index für das letzte 
            //Zeichen zu erhalten das wir bei 0 anfangen zu zählen.

            //Console.WriteLine(letztesZeichenVonText);//Wir geben den entsprechenden Char in der Konsole aus

            //Aufgabe :
            //Ein User soll seine Postleitzahl eingeben können.
            //Es soll geprüft werden ob die Postleitzahl fünf stellen hat.
            //Ist dies nicht der Fall soll Ungültige Postleizahl angegeben werden.
            //Wenn die PLZ korrekt ist soll die Zugehörige Region ermittelt werden.
            //Postleitzahlenregionen:   Mit 0 oder 1 beginnend  => Ostdeutschland
            //                          Mit 2 beginnend         => Nordeutschland
            //                          Mit 3 beginnend         => Mitteldeutschland
            //                          Mit 4 oder 5 beginnend  => Westdeutschland
            //                          Mit 6,7,8 oder 9 beginnend => Süddeutschland
            //Wenn es keine dieser Zeichen ist dann soll gesagt werden das die PLZ nicht verarbeitet werden kann.

            //Console.WriteLine("Hallo User gib bitte deine PLZ an:");
            //string plz = Console.ReadLine();
            //bool plzOk = plz.Length == 5;
            //string region = "";
            //if (!plzOk) 
            //{
            //    Console.WriteLine("Ungültige PLZ, eine Postleitzahl verfügt über fünf Stellen");
            //}
            //else
            //{
            //    char erstesZeichen = plz[0];
            //    switch (erstesZeichen)
            //    {
            //        case '0':
            //        case '1':
            //            region = "Ostdeutschland";
            //            break;
            //        case '2':
            //            region = "Norddeutschland";
            //            break;
            //        case '3':
            //            region = "Mitteldeutschland";
            //            break;
            //        case '4':
            //        case '5':
            //            region = "Westdeutschland";
            //            break;
            //        case '6':
            //        case '7':
            //        case '8':
            //        case '9':
            //            region = "Süddeutschland";
            //            break;
            //        default:
            //            Console.WriteLine("Die Eingabe kann leider so nicht verarbeitet werden. \nEine PLZ muss mit einer Zahl beginnen.");
            //            plzOk = false;
            //            break;


            //    }
            //}
            //if (plzOk) 
            //{
            //    //Es gibt verschiedene Möglichkeiten Variablen in einem String einzubinden.

            //    //Interploation
            //    string ausgabe = $"Du hast folgende PLZ eingegeben: {plz}. \nDu kommst aus {region} ";

            //    //Konkatenation
            //    ausgabe = "Du hast folgende PLZ eingegeben " + plz + "\nDu kommst aus " + region;

            //    //Komposition
            //    ausgabe = String.Format("Du hast folgende PLZ eingegeben {0}. \nDu kommst aus {1}", plz, region);

            //    Console.WriteLine(ausgabe);
            //}

            //Aufgabe2:

            //Der User soll angeben können, wieviel Bier in Litern getrunken wurde.
            //Daraus wird die Menge des Reinalkohols in Gramm berechnet.
            //Getrunkene Menge in Milliliter * Alkoholgehalt * Dichte des Ethanols.
            //Bei Bier also: Getrunkene Menge in Milliliter * 0.05 * 0.8
            //Der User soll auch sein Gewicht in Kilogramm angeben.
            //Dann wird der Blutalkoholgehalt in Promille berechnet.
            //c = A / (0.65*G)
            //c ist der Promillewert, A der aufgenommene Alkohol in Gramm und G das Körpergewicht in kg.
            //Es soll dann eine Ausgabe, abhängig vom Promillewert folgen:
            //bis 0.3: "Noch akzeptabel. Dennoch vorsichtig sein!"
            //bis 0.5: "Achtung! Hände weg vom Steuer!"
            //bis 0.8: "Das ist jetzt schon ganz schön ordentlich."
            //ab 0.8: "Kein Kommentar..."
            //Wählen Sie passende Datentypen für die jeweils notwendigen Variablen.

            


            double getrunkeneMenge;
            double gewicht;
            double alkGehalt = 0.05d;
            double ethDichte = 0.8d;
            double reinalk;
            double promille;

            Console.WriteLine("Hallo User! Wieviel Bier hast du denn getrunken? Gib die menge in Litern an.");
            getrunkeneMenge = Convert.ToDouble(Console.ReadLine())*1000;
            Console.WriteLine("Gebe dein Gewicht in Kilogramm an.");
            gewicht = Convert.ToDouble(Console.ReadLine());

            reinalk = getrunkeneMenge * alkGehalt * ethDichte;

            promille = Math.Round((reinalk / (0.65d * gewicht)), 2);

            Console.WriteLine($"{promille} Promille");

            if(promille <= 0.3d)
            {
                Console.WriteLine("Noch akzeptabel. Dennoch vorsichtig sein!");

            }
            else if (promille > 0.3d && promille <= 0.5d)
            {
                Console.WriteLine("Achtung! Hände weg vom Steuer!");
            }
            else if (promille > 0.5d && promille <= 0.8d)
            {
                Console.WriteLine("Das ist jetzt aber schon ganz ordentlich");
            }
            else if (promille > 0.8d)
            {
                Console.WriteLine("Kein Kommentar");
            }
            else
            {
                Console.WriteLine("Da ist was schief gelaufen. Etwa schon zu viel getrunken?");
            }
           
        }
    }
}
