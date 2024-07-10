namespace Taskmaster
{
  public class Tasky
  {
    // Eigenschaften kommen hier hin:
    public bool IsComplete;
    // Konstruktor soll hier implementiert werden:

    public Tasky(string title, string description, DateTime dueDate)
    {
    }

    // Beschreibung der Aufgabe
    public string GetTaskInfo()
    {
    }

    // Markierung der Aufgabe als erledigt
    public void CompleteTask()
    {
    }

    // Verlängerung des Fälligkeitsdatums
    public void ExtendDueDate(DateTime newDueDate)
    {
    }
  }
}
