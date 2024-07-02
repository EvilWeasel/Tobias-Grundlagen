namespace _03Userinteraktion
{
    internal class Program
    {
#pragma warning disable CS0219 // Unnecessary assignment of a value
#pragma warning disable CS0168 // Unnecessary assignment of a value
#pragma warning disable CS8600 // Unnecessary assignment of a value
    static void Main(string[] args)
        {
            //Console.WriteLine("Hallo User! Bitte gib ein Wort ein.");
            //Mit der Methode ReadLine kann man die nächste Zeile, in unserem Fall das was der User eingeben wird, einlesen.
            //Die Zeichenkette muss in einer Variablen gespeichert werden. Der Wert, also Inhalt der Variablen, ist dann zur Laufzeit
            //des Programms im Arbeitsspeicher vorhanden.

            //string userInput = Console.ReadLine();

            //Ausgabe des im Arbeitsspeicher vorliegenden Werts über die Variable userInput
            //Console.WriteLine($"Du hast folgendes eingegeben: \t\t{userInput}\n");
            //Console.WriteLine("Das hast du bisher gut gemacht!");
            Console.WriteLine("Gib bitte als nächstes deinen Vorname ein: ");
            string vorname = Console.ReadLine();
            //Aufgabe: der User soll neben seinem Vornamen auch Nachname, E-Mail-Adresse, Hobby und Alter  eingeben können.
            //Gebe dann die gespeicherten Daten in der Konsole aus.

            string nachname, email, hobby, alter;

            Console.WriteLine($"Hallo {vorname}, bitte gib deinen Nachnamen ein");
            nachname = Console.ReadLine();
            Console.WriteLine("Gib bitte deine E-Mail ein:");
            email = Console.ReadLine();
            Console.WriteLine("Gib dein Hobby an:");
            hobby = Console.ReadLine();
            Console.WriteLine("Gib dein Alter an:");
            alter = Console.ReadLine();

            Console.WriteLine($"Deine eingegeben Daten: \n\nVorname: \t{vorname}\nNachname: \t{nachname}\nE-Mail: \t{email}\nHobby: \t\t{hobby}\nAlter: \t\t{alter}");
            


        }
    }
}