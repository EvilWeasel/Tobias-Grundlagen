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
      var low = 0;
      var high = numbers.Count - 1; // Der höchste Index
      int mid = 0;
      while (high >= low)
      {
        mid = (high + low) / 2;
        if (numbers[mid] == query) return mid;
        else if (numbers[mid] < query)
        {
          low = mid + 1;
        }
        else
        {
          high = mid - 1;
        }
      }
      // if (numbers[mid] == query) return mid;
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

    /// <summary>
    /// Eine Funktion, welche eine Liste mit Integers bekommt, und in der Konsole
    /// die Häufigkeit jedes Elements druckt.
    /// Beispiel
    /// Input: [1,2,3,3,5,2,-10,-10]
    ///
    /// Output:
    /// Zahl 1: 1
    /// Zahl 2: 2
    /// Zahl 3: 2
    /// Zahl 5: 1
    /// Zahl -10: 2
    /// </summary>
    internal static void GroupBy(List<int> numbers)
    {
      /*
      Dictionary<int, int> dict = new();
      var isOneInNumbers = dict.ContainsKey(1); // true or false
      dict[5] = 1;
      dict[5]++;
      */
      /*
        int[,] groupedNumbers = new int[numbers.Count, 2];
        // [[1,1],[2,2],[3,2],[5,1],[-10,2],[],[],[]]
        groupedNumbers[0,0] = 1;
        groupedNumbers[0,1] = 1;
        groupedNumbers[1, 0] = 2;
        groupedNumbers[1, 1] = 2;
        groupedNumbers[2, 0] = 3;
        groupedNumbers[2, 1] = 1;
      */
      // [[1,1],[2,2],[3,2],[5,1],[-10,2],[],[],[]]
      // [1,1,2,2,3,2,5,1,-10,2]
      /*
        var groupedNumbers = new int[numbers.Count * 2];
        groupedNumbers[0] = 1;
        groupedNumbers[1] = 1;
        groupedNumbers[4] = 3;
        groupedNumbers[5] = 2;
      */

    }

    /// <summary>
    /// Eine Funktion, welche einen Weihnachtsbaum in der Konsole druckt.
    /// Input: Wie gewünscht
    /// Output (Console.WriteLine()):
    ///    #
    ///   ###
    ///  #####
    /// #######
    ///    #
    /// BaumBauer();
    /// </summary>
    internal static void BaumBauer(int height = 5)
    {
      /*
      Console.WriteLine("   #");
      Console.WriteLine("  ###");
      Console.WriteLine(" #####");
      Console.WriteLine("#######");
      Console.WriteLine("   #");
      Console.WriteLine("     #");
      Console.WriteLine("    ###");
      Console.WriteLine("   #####");
      Console.WriteLine("  #######");
      Console.WriteLine(" #########");
      Console.WriteLine("###########");
      Console.WriteLine("   #");
      */
      Console.WriteLine("BaumBauer v.1.0");
      int hashNumber = 1;
      int whitespaceAmount = height - 2;
      // var thisLine = new string('#', 10);
      // Console.WriteLine(new string(' ',whitespaceAmount));
      for (int i = 0; i < height; i++) // Eine Zeile
      {
        // Whitespace vor dem #
        for (int j = 0; j < whitespaceAmount; j++)
        {
          Console.Write(" ");
        }
        // hashtags => #
        for (int j = 0; j < hashNumber; j++)
        {
          Console.Write("#");
        }
        /* auch mit if möglich
         if (height == i - 1) { }
         Nach jeder Zeile
        */
        hashNumber += 2;
        whitespaceAmount--;
        Console.WriteLine();
      }
      // spezialfall
      whitespaceAmount = height - 2;
      // Whitespace vor dem #
      for (int j = 0; j < whitespaceAmount; j++)
      {
        Console.Write(" ");
      }
      Console.Write("#\n");
    }

    /// <summary>
    /// Eine Funktion, welche einen Diamanten in der Konsole druckt.
    /// Input: Wie gewünscht
    /// Output (Console.WriteLine()):
    ///    #
    ///   ###
    ///  #####
    /// #######
    ///  #####
    ///   ###
    ///    #
    /// DiamondBauer();
    /// </summary>
    internal static void DiamondBauer() { }

    /// <summary>
    /// Finde den niedrigsten Wert in einem Array arbiträrer Länge, und gebe diesen Zurück.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns>Der niedrigste Wert, aus dem gegebenen Array</returns>
    internal static int FindSmallestValue(int[] numbers)
    {
      int minimum = numbers[0];
      foreach (int number in numbers)
        if (number < minimum)
          minimum = number;
      return minimum;
    }

    /// <summary>
    /// Gebe eine neue Liste zurück, welche nur alle geraden Zahlen beinhaltet.
    /// Input: [1,2,3,4,5,6]
    /// Output: [2,4,6]
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    internal static List<int> OnlyEven(List<int> numbers)
    {
      List<int> evenNumbers = new();
      foreach (int number in numbers)
        if (number % 2 == 0)
          evenNumbers.Add(number);
      return evenNumbers;
    }

    /// <summary>
    /// Eine Funktion, welche true zurückgibt, wenn ein (oder mehrere) Werte doppelt vorkommen.
    /// Examples:
    /// <list type="bullet">
    /// <item>
    /// Input: [0,1,2,3]
    /// Output: False
    /// </item>
    /// <item>
    /// Input: [0,1,2,2,3,4,5]
    /// Output: True
    /// </item>
    /// <item>
    /// Input: [0,1,1,2,3,4,4]
    /// Output: True
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    internal static bool ContainsDuplicates(int[] numbers) { return false; }

  }
}
