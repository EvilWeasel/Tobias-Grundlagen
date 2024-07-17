using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
  internal class EnumExample
  {
    public void Run()
    {
      List<WeatherForecast> forecasts = new();

      // Enum als String (Textwert; Vergleich bei Console.ReadLine())
      bool isSlovakia = OrderCountryPrefix.Slovakia.ToString() == "Slovakia"; // true
                                                                              // Enum als Int (Vergleich mit Userinput bei int.Parse(), oder so)
      bool isGermany = (int)OrderCountryPrefix.Germany == 1000; // true
                                                                // Int als Enum (Ausgabe des Textwertes, bei numerischer Eingabe)
      bool isItaly = (OrderCountryPrefix)3000 == OrderCountryPrefix.Italy; // true

      forecasts.Add(
        new WeatherForecast("Heilbronn", new DateTime(2024, 7, 11, 10, 33, 00), 99, 4, Season.Summer)
      );
      forecasts.Add(
        new WeatherForecast("Stuggi", new DateTime(2024, 12, 11, 10, 33, 00), 70, 3, Season.Winter)
      );
      forecasts.Add(
        new WeatherForecast("Was wenn andere Season?", new DateTime(2024, 12, 11, 10, 33, 00), 70, 3, (Season)1)
      );

      foreach (var forecast in forecasts)
      {
        if (forecast.Season == Season.Summer)
          Console.WriteLine(forecast.Season);
      }

      Console.WriteLine(OrderCountryPrefix.Slovakia);

      Console.WriteLine("Gebe den Ländercode ein um das Land auszuwählen:");
      string userinput = Console.ReadLine();
      int userCountryPrefix = 10;

      // Implizites Casting != Parsing 
      // Parsing ist Convertieren von einem Typ zu einem anderen.
      // Casting ist "OrderCountryPrefix ist auch ein Integer-Wert, vergleiche den Userinput als int mit dem Enum als int"
      if (userinput == OrderCountryPrefix.Slovakia.ToString())
      {
        Console.WriteLine("Is Slovakia");
      }

      Console.WriteLine("Enum to Int:" + (int)OrderCountryPrefix.Slovakia);
      switch (userCountryPrefix)
      {
        case (int)OrderCountryPrefix.Germany:
          Console.WriteLine("Deutschland");
          break;
        case (int)OrderCountryPrefix.Slovakia:
          Console.WriteLine("Slovakia");
          break;
        case (int)OrderCountryPrefix.Italy:
          Console.WriteLine("Italy");
          break;
        default:
          Console.WriteLine("uhm....");
          break;
      }

      Console.WriteLine("Int to Enum:" + (OrderCountryPrefix)userCountryPrefix);
    }

    class WeatherForecast
    {
      public WeatherForecast(string location, DateTime forecastDayTime, int chanceOfRain, int sunhours, Season season)
      {
        Location = location;
        ForecastDayTime = forecastDayTime;
        ChanceOfRain = chanceOfRain;
        Sunhours = sunhours;
        Season = season;
      }

      public string Location { get; set; }
      public DateTime ForecastDayTime { get; set; }
      public int ChanceOfRain { get; set; }
      public int Sunhours { get; set; }
      public Season Season { get; set; }
    }

    /// <summary>
    /// Ein Enum ist ein Wertetyp, der aus einer fest definierten Liste an Konstanten besteht.
    /// Die Werte hinter dem Enum sind als Typ `int` gespeichert, fangen mit 0 an, und erhöhen sich immer um 1 (Wie ein Array?).
    /// </summary>
    enum Season
    {
      Spring,
      Summer,
      Autumn,
      Winter,
    }

    enum OrderCountryPrefix
    {
      Germany = 1000,
      Slovakia = 9000,
      Italy = 3000
    }
  }
}
