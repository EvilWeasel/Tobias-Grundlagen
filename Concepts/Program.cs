using ConsoleHelpers;

string[] names = new string[] { "Tobi", "Michi", "Thorsten", "Silvio" };

Random random = new();

double x = random.NextDouble();

int randomNumber = random.Next(names.Length);

// Print random name
Console.WriteLine(names[randomNumber]);

int asciiNumber = random.Next(65, 123);

Console.WriteLine(asciiNumber);


Helpers.TypeWriter("Hier könnte Ihre Werbung stehen!", 100);
Helpers.TypeWriter("Hier könnte Ihre Werbung stehen!", 100);
