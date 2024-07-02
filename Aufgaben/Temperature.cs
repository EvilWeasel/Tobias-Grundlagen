using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
  internal static class Temperature
  {
    internal static List<int> AboveMin(List<int> temperatures, int tempLimit) 
    {
      List<int> tempIndicesAboveLimit = new();
      for (int index = 0; index < temperatures.Count; index++)
      {
        if(temperatures[index] > tempLimit)
          tempIndicesAboveLimit.Add(index);
      }

      return tempIndicesAboveLimit;
    }
    // Hier könnte eure Aufgabe stehen!
    internal static double Average(List<int> temperatures)
    {
      double sum = 0;
      foreach(int temp in temperatures)
      {
        // int temp = temperatures[i]
        sum = sum + temp;
      }
      // Der foreach-loop macht das gleiche wie der folgende for-loop
      // for (int i = 0; i < temperatures.Count; i++)
      // {
      //   
      //   sum = sum + temperatures[i];
      // }
      double avg = sum / temperatures.Count;
      return avg;
    }
  }
}
