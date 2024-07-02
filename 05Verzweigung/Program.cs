namespace _05Verzweigung
{
  internal class Program
  {
#pragma warning disable CS0219 // Unnecessary assignment of a value
#pragma warning disable CS0168 // Unnecessary assignment of a value
#pragma warning disable CS8600 // Unnecessary assignment of a value
    static void Main(string[] args)
    {
      //Bedingte Anwisungen und Verzweigungen sind Kontrollstrukturen.
      //Diese ermöglichen uns, den Fluss des Codes und damit welche Teile
      //des Codes ausgeführt werden sollen zu bestimmen.


      //Arbeiten mit Wahrheitswerten (Booleans)
      bool istHeuteMontag = false;
      //Console.WriteLine($"Stimmt es das heute Montag ist?: {istHeuteMontag}");

      //Logische Operatoren
      bool b1 = !true; //andert den Wert in das Gegenteil. Dies wird auch als toggle bezeichnet
      bool b2 = false && true; //&& AND: Ergibt true wenn alle Werte true sind.
      bool b3 = true || true || false; // OR: Ergibt true wenn mindestens ein Wert true ist.
      bool b4 = false ^ false ^ false ^ false; //^ XOR: Ergibt True wenn die Anzahl an True werten ungerade sind. 

      //Vergleichsoperatoren

      int x1 = 1, x1b = 1, x2 = 2, x3 = 3;

      bool b5 = (x1 == x1b); // == Ergibt True wenn beide Werte gleich sind
      bool b6 = (x1 <= x1b); // < > <= >= kleiner, größer ,  kleiner gleich , größer gleich: Ergibt true wenn die Bedingung erfühlt ist
      bool b7 = (x1 != x1b); // != Ergibt true wenn beide Werte nicht gleich sind.

      //Alle Operatoren können miteinander kombiniert werden:
      bool b8 = (x1 < x3) || (x2 > x3);
      //Console.WriteLine(b8);


      bool istHeuteWerktag = false;

      //if(istHeuteWerktag == true)
      //{
      //    //DANN 
      //    Console.WriteLine("Der Wecker klingelt um 06:30");
      //}
      //else //ANSONSTEN
      //{
      //    Console.WriteLine("Wochenende! Ausschlafen!");
      //}


      bool istHeuteMittwoch123123 = (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday);
      istHeuteMontag = (DateTime.Now.DayOfWeek == DayOfWeek.Monday);

      //if (istHeuteMittwoch123123)
      //{
      //    Console.WriteLine("Heute ist Mittwoch!!");
      //}
      //else
      //{
      //    if (istHeuteMontag)
      //    {
      //        Console.WriteLine("Heute ist Montag");
      //    }
      //    else
      //    {
      //        Console.WriteLine("Heute ist weder montag noch Mittwoch");
      //    }
      //}

      //Aufgabe:
      //Der User soll ein Passwort eingeben. Er hat drei Versuche um das Passwort richtig einzugeben.
      //Nach jedem Fehlversuch, soll angegeben werden wieviele Versuche noch übrig bleiben.
      //Nach dem dritten Fehlversuch soll die Meldung kommen: "Konto gesperrt"

      //string passwort = "1234";
      //int anzahlVersuche = 3;
      //Console.WriteLine($"User, bitte gib dein Passwort ein, du hast {anzahlVersuche} Versuche");
      //string userEingabe = Console.ReadLine();
      //bool userHatRichtigesPasswort = (passwort == userEingabe);
      //if (userHatRichtigesPasswort)
      //{
      //    Console.WriteLine("Du bist eingeloggt. Willkomen im System User. ");
      //}
      //else
      //{
      //    Console.WriteLine("Du hast das falsche Passwort eingegeben");
      //    anzahlVersuche --; //Zieht 1 ab von anzahlVersuche übrig bleibt 2
      //    Console.WriteLine($"Versuche es nochmal und gebe dein passwort ein. Du hast noch {anzahlVersuche} Versuche.");
      //    userEingabe = Console.ReadLine();
      //    userHatRichtigesPasswort = (passwort == userEingabe);
      //    if (userHatRichtigesPasswort)
      //    {
      //        Console.WriteLine("Du bist eingeloggt. Willkomen im System User. ");
      //    }
      //    else
      //    {
      //        Console.WriteLine("Du hast das falsche Passwort eingegeben");
      //        anzahlVersuche--;
      //        Console.WriteLine($"Versuche es nochmal und gebe dein passwort ein. Du hast noch {anzahlVersuche} Versuche.");
      //        userEingabe = Console.ReadLine();
      //        userHatRichtigesPasswort = (passwort == userEingabe);
      //        if (userHatRichtigesPasswort)
      //        {
      //            Console.WriteLine("Du bist eingeloggt. Willkomen im System User. ");
      //        }
      //        else
      //        {
      //            Console.WriteLine("Du hast wiederholt das falsche Passwort eingegeben, dein Konto wird gesperrt!");
      //        }
      //    }
      //}
      //Aufgabe2:
      //Der User soll Ihnen mitteilen, ob das Wetter gerade "sonnig" oder "regnerisch" ist. 
      //Auch die Temperatur soll der User angeben können.
      //Liegt die Temperatur bei oder über 20°C und es ist sonnig, empfehlen sie dem User ein T-Shirt zu tragen.
      //Liegt die Temperatur unter 20°C und es ist sonnig, empfehlen Sie eine Jacke anzuziehen.
      //Bei regnerischen Wetter müssen ebenfalls die Kleiderempfehlung ausgesprochen werden die sich nach der jeweiligen Temperatur richten.
      //Zusätzlich soll der User drauf hingewiesen werden, dass ein Regenschirm mitgenommen werden soll.

      //Console.WriteLine("Hallo User bitte gebe an ob es sonnig oder regnerisch ist:");
      //string wetter = Console.ReadLine();
      //Console.WriteLine("Gib bitte noch an wieviel Grad die Temperatur hat:");
      //int temperatur = Convert.ToInt32(Console.ReadLine());

      //if(wetter == "sonnig")
      //{
      //    if(temperatur >= 20)
      //    {
      //        Console.WriteLine("Es ist sonnig ziehe doch ein T-shirt an");
      //    }
      //    else
      //    {
      //        Console.WriteLine("Schönes Wetter , aber ziehe eine Jacke an");   
      //    }
      //}
      //else
      //{
      //    if(wetter == "regnerisch")
      //    {
      //        if (temperatur >= 20)
      //        {
      //            Console.WriteLine("Es ist Warm ziehe doch ein T-shirt an aber nimm auch einen Regenschirm mit");
      //        }
      //        else
      //        {
      //            Console.WriteLine("Schlechtes Wetter , ziehe eine Jacke an und nimm einen Schirm mit");
      //        }
      //    }
      //    else
      //    {
      //        Console.WriteLine("Die Eingabe ist innkorrekt");
      //    }
      //}

      //if(temperatur >= 20 && wetter == "sonnig")
      //{
      //    Console.WriteLine("Schönnes Wetter, da sollte ein T-Shirt reichen");
      //}
      //else if(temperatur >= 20 && wetter == "regnerisch") //else if ermöglicht uns weiter Bedingungen abzufragen in einer Kontroll logik
      //{
      //    Console.WriteLine("T-Shirt Zeit aber nimm einen Schirm mit");
      //}
      //else if(temperatur < 20 && wetter == "sonnig")
      //{
      //    Console.WriteLine("Hey voll schön draußen aber nimm eine Jacke mit");
      //}
      //else if (temperatur < 20 && wetter == "regnerisch")
      //{
      //    Console.WriteLine("Kein gutes Wetter, nimm schirm und Jacke mit");
      //}
      //else
      //{
      //    Console.WriteLine("Da ist was schief gelaufen!");
      //}


      //Aufgabe 3 :
      //Wenn der User etwas anderes als eine der drei Vorgaben auswählt, soll "Ungültige Eingabe" ausgegeben werden.
      //Andernfalls soll die Koonsollenschriftfarbe in die entsprechende Auswahl geändert werden. (Recherchiert selber wie man die Farbe ändert)
      //Der User darf dabei entweder den Anfangsbuchstaben verwenden oder das ganze Wort.
      //Und die Aufgabe soll mit switch-case umgesetzt werden, es darf keine if und else struktur geben.
      //(Selbstständig recherchieren wie man switch case nutzt)

      Console.WriteLine("User, wähle eine Farbe aus: (r)ot, (b)lau, (g)gelb");
      string farbe = Console.ReadLine();
      farbe = farbe?.ToLower(); //.ToLower() ist eine Methode die jeder String besitzt. Damit werden Alle Buchstaben im String zu Kleinbuchstaben.

      //Mehseitige Fallauswahl: Switch



      switch (farbe)
      {
        case "r":
        case "rot":
          Console.ForegroundColor = ConsoleColor.Red;
          break;
        case "b":
        case "blau":
          Console.ForegroundColor = ConsoleColor.Blue;
          break;
        case "g":
        case "gelb":
          Console.ForegroundColor = ConsoleColor.Yellow;
          break;

        default:
          Console.WriteLine("Ungültige Eingabe");
          break;

      }
      Console.WriteLine("Neue Farbe wenn geändert");

    }
  }
}