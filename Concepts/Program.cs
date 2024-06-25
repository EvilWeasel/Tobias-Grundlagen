int[] numbers = { 1, 2, 3, 4, 5 };

NumbersArray numbersArray = new NumbersArray(numbers);

Console.WriteLine(numbersArray);

// Mein Number Array Datentyp
public class NumbersArray
{
  public int[] numbers = [];

  public NumbersArray(int[] numbers)
  {
    this.numbers = numbers;
  }

  // Überschreibe die ToString Methode, weil C# sonst nicht weiß, wie es das Objekt ausgeben soll
  public override string ToString()
  {
    return string.Join(", ", numbers);
  }
}