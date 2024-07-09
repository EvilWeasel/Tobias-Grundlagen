using Buchverwaltungssystem;

// Konstruktor-Aufrufer
// Hier müssen wir die Parameter des Konstruktors angeben!
// var mybook = new Book() { Title = "Buxtehude", Author = "Max", ISBN = "ksdfjolsdjf", PublicationYear = 2000};

var mybook = new Book("Star Wars Republic Commando: Hard Contact", "Karen Traviss", 2004, "00000000000");
var description = mybook.GetDescription();

Console.WriteLine(mybook.Title);

Console.WriteLine(description);
// Console.WriteLine(mybook.GetDescription());