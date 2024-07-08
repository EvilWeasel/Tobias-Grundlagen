namespace Concepts
{
  /// <summary>
  /// Eine Klasse ist ein selbst-definierter Datentyp.
  /// Eine Klasse instanziiert ein Objekt vom Typ der Klasse.
  /// Eine Klasse besitzt Eigenschaften und Methoden.
  /// Vor dem Keyword class (oder dem Return-Type einer Funktion/Methode) lässt sich ein Access-Modifier definieren:
  ///   Access-Modifier definieren an welchen Stellen im Code die jeweilige Klasse oder Methode oder Eigenschaft sich aufrufen lässt.
  ///   Valide Access-Modifier in C#: internal, private, public, protected
  ///   
  /// PS: Keine Access-Modifier für Namespaces
  /// </summary>
  internal class Person
  {
    // Eigenschaft => Eine Variable für diese Objekt
    // Auch Eigenschaften haben Access-Modifier
    internal string Vorname = "";
    internal string? Nachname; // Dieser string ist nullable => kann uninitialisiert sein.

    // Methode => Eine Aktion, welche mein Objekt tätigen kann
    internal void Greet(string greeting)
    {
      Console.WriteLine(Vorname + " " + Nachname + " Begrüßt dich mit: " + greeting);
    }
  }
}
