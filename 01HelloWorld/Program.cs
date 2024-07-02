namespace _01HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ich bin ein einzeiliger Kommentar. 
            //Wir sind hier in einer methode namens "Main" die sich in einer Klasse befindet namens "Program",
            //die sich in unserem Namespace befindet.

            /*
             ich bin ein mehrzeiliger
            Komentar
            */

            //Der Console WriteLine-Befehl führt dazu, dass eine Ausgabe in der Konsole erfolgt.
            Console.WriteLine("Hallo Welt");
            Console.WriteLine("Konsole, Schreibe noch eine Zeile");
            Console.WriteLine("und noch eine Zeile");
            
            //Mit \n wird ein Zeilenumbruch deklariert:
            Console.WriteLine("Hallo Welt!\nKonsole, schreibe eine neue Zeile!");

            //Mit \t hat man einen Tabulator-Einzug:
            Console.WriteLine("1.\tDie erste Zeile");

            //.Write schreibt in eine Zeile.
            Console.Write("Hello World! ");
            Console.Write("I will print on the same Line");
            Console.WriteLine("Hallo Welt"); // Ist das Gleiche wie:
            Console.Write("Hallo Welt\n");
            





        }
    }

}