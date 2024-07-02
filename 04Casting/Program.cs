namespace _04Casting
{
    internal class Program
    {
#pragma warning disable CS0219 // Unnecessary assignment of a value
#pragma warning disable CS0168 // Unnecessary assignment of a value
#pragma warning disable CS8600 // Unnecessary assignment of a value
    static void Main(string[] args)
        {
            //Casting ist die Möglichkeit einen Datentyp in einen anderen zu konvertieren.
            short klein = 1;
            int mittel = klein; //implizites Casting
            

            mittel = 32767 + 1;
            klein = (short)mittel; //explizites Casting, der Zieldatentyp wird in die Klammern geschrieben.
            //Console.WriteLine(klein);

            double kommazahl = 5.5;
            int ganzahl = (int)kommazahl;
            //Console.WriteLine(ganzahl);
            double nachkommaZahl = kommazahl - ganzahl;
            //Console.WriteLine($"{nachkommaZahl} ist der Wert nach dem Komma von {kommazahl}");

            //Mit Hilfe der Convert-Klasse können wir einen String in einen Zahlendatentyp umwandeln.
            string zeichenkette = "2"; //Dieser String lässt sich innach int konvertieren
            string zeichenkette2 = "2b"; // Dieser String lässt sich nich nach int konvertieren;
            int zahl = Convert.ToInt32(zeichenkette);
            //Console.WriteLine(zahl);

            //Beispiel
            string name;
            int alter;

            Console.WriteLine("Hallo User! Bitte gib deinen Namen ein.");
            name = Console.ReadLine();

            Console.WriteLine("Gib bitte noch dein Alter an");
            //alter = Convert.ToInt32(Console.ReadLine());
            string alterString = Console.ReadLine(); ;
            alter = Convert.ToInt32(alterString);
            Console.WriteLine($"Hallo {name}. In einem jahr bist du {alter + 1} Jahre alt.");

            //Aufgabe: Es soll eine zweite Person Name und Alter eingeben
            //Dann soll das Durchschnittsalter der beiden Personen berechnet und auch ausgegeben werden.

            string name2;
            int alter2;

            Console.WriteLine("Hallo User2, Bitte gib deinen Namen ein:");
            name2 = Console.ReadLine();
            Console.WriteLine("Gib Bitte Dein Alter ein:");
            alter2 = Convert.ToInt32(Console.ReadLine());

            double durchschnittsalter = (alter + alter2) / 2d;
            Console.WriteLine($"Euer Durchschnittsalter beträgt: {durchschnittsalter} Jahre");
        }
    }
}