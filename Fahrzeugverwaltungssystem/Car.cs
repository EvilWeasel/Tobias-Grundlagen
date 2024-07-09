namespace Fahrzeugverwaltungssystem
{
  internal class Car
  {
    internal string Brand { get; set; }
    internal string Model { get; set; }
    internal int Year { get; set; }
    internal int Mileage { get; set; }

    internal Car(string brand, string model, int year, int mileage)
    {
      Brand = brand;
      Model = model;
      Year = year;
      Mileage = mileage;
    }

    internal string GetDescription()
    {
      return $"\"{Brand} {Model}, Jahr {Year} mit {Mileage} km gefahren.\"";
    }

    internal void Drive(int drivenMiles)
    {
      Mileage += drivenMiles;
      // Mileage = Mileage + drivenMiles;
    }

    internal int Age()
    {
      return DateTime.Now.Year - Year;
    }
  }
}
