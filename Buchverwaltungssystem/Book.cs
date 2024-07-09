namespace Buchverwaltungssystem
{
  internal class Book
  {
    /*
    private string _title;
    internal string Title
    {
      get
      {
        return _title;
      }
      set
      {
        if (_title != value)
          _title = value;
      }
    }
    var book1 = new Book();
    book1.Title = "abc"
    Console.WriteLine(book1.Title)
    */
    internal string Title { get; set; }
    internal string Author { get; set; }
    internal int PublicationYear { get; set; }
    internal string ISBN { get; set; }

    internal Book(string title, string author, int publicationYear, string isbn)
    {
      this.Title = title;
      Author = author;
      PublicationYear = publicationYear;
      ISBN = isbn;
    }

    internal string GetDescription()
    {
      // Escape-Sequence => \n \t
      // Mit dem Backslash (\), sagen wir C#, dass die Anführungszeichen ein Teil des Strings sind.
      return $"\"{Title}\" von {Author}, veröffentlicht im Jahr {PublicationYear} (ISBN: {ISBN}).";
    }
  }
}
