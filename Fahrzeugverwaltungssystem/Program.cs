using Fahrzeugverwaltungssystem;

var car = new Car("Audi", "A3", 2023, 20_000); // new => Konstruktoraufruf => Sprachkonvention
car.Drive(50);
Console.WriteLine(car.GetDescription());
Console.WriteLine($"Das Alter des Fahrzeugs ist: {car.Age()}");

var car2 = new Car("Opel", "Kapitän", 1982, 200_000); // new => Konstruktoraufruf => Sprachkonvention
car2.Drive(500);
Console.WriteLine(car2.GetDescription());
Console.WriteLine($"Das Alter des Fahrzeugs ist: {car2.Age()}");