namespace Aufgabenverwaltungssystem
{
  public class Tasky
  {
    // Eigenschaften kommen hier hin:
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    // Konstruktor soll hier implementiert werden:
    public Tasky(string title, string description, DateTime dueDate)
    {
      Title = title;
      Description = description;
      DueDate = dueDate;
      IsCompleted = false;
    }

    // Beschreibung der Aufgabe
    public string GetTaskInfo()
    {
      return $"Title: {Title}, Beschreibung: {Description}, Fällig bis: {DueDate}, Erledigt: {IsCompleted}";
    }

    // Markierung der Aufgabe als erledigt
    public void CompleteTask()
    {
      IsCompleted = true;
    }

    // Verlängerung des Fälligkeitsdatums
    public void ExtendDueDate(DateTime newDueDate)
    {
      DueDate = newDueDate;
    }
  }
}
