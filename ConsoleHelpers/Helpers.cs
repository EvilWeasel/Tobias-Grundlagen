namespace ConsoleHelpers
{
  public static class Helpers
  {
    public static void TypeWriter(string text, int milisecondDelay)
    {
      foreach(char c in text)
      {
        Console.Write(c);
        Thread.Sleep(milisecondDelay);
      }
      Console.Write("\n");
    }
  }
}
