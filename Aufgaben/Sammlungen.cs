using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
  
  internal static class Sammlungen
  {
    // FindIndex Optimized
    internal static int FindIndexOptimized(List<int> numbers, int query)
    {
      return -1;
    }


    /// <summary>
    /// Eine Funktion, welche eine Sammlung und ein gesuchtes Element übergeben bekommt,
    /// und den entsprechenden Index des El ements im Array zurück gibt.
    /// </summary>
    internal static int FindIndex(List<int> numbers, int query)
    {
      // iterieren (durchzählen) durch numbers
      // wenn: numbers[i] == query
      //   return i;
      for (int i = 0; i < numbers.Count; i++)
      {
        if (numbers[i] == query) return i;
      }
      // wenn query nicht gefunden, return -1
      return -1;
    }
    internal static int FindIndexAlt(List<int> numbers, int query)
    {
      // iterieren (durchzählen) durch numbers
      // wenn: numbers[i] == query
      //   return i;
      for (int i = numbers.Count - 1; i > 0; i--)
      {
        if (numbers[i] == query) return i;
      }
      // wenn query nicht gefunden, return -1
      return -1;
    }

    internal static List<int> GenerateNumbers(int amount) 
    {
      List<int> numbers = new();
      for (int i = 0; i < amount; i++) 
        numbers.Add(i);
      return numbers;
    }
  }
}
