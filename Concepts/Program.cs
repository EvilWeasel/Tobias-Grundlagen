using Concepts;

var stringtest = "buxtehude";
Person person1 = new Person("Michael", "Lutz"); // Konstruktoraufruf
// var personPseudoKonstruktor = Person.Konstruktor("Michael", "Lutz");

// Erstellen eines neuen Objekts durch aufrufen einer Konstruktor-Methode
// var person2 = new Person("Michael", "Lutz");
// person1.Greet("Hallo!"); // Kann Fehler verursachen, wenn Vorname und Nachname nicht initialisiert wurden
stringtest.ToLower();
// person1.Vorname = "Michael";
// person1.Nachname = "Lutz";

person1.Greet("Hallo!"); // Vorname und Nachname müssen vorher gesetzt sein!

Console.WriteLine($"{person1}"); // Druckt Namespace.Klasse
// Console.WriteLine(person1);


// example namespace datatype
// System.Collections.Generic[Concepts.Person]
/*
List<Person> people = new List<Person>();
List<int> ints;
List<DateTime> times;
Console.WriteLine(people);
*/


