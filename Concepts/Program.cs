using Concepts;

var stringtest = "buxtehude";
Person person1 = new Person(); // Konstruktoraufruf

// Erstellen eines neuen Objekts durch aufrufen einer Konstruktor-Methode
// var person2 = new Person("Michael", "Lutz");

stringtest.ToLower();
person1.Vorname = "Michael";
person1.Nachname = "Lutz";

person1.Greet("Hallo!");

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


