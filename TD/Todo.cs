using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TD
{
  public class Todo
  {
    public static List<Todo> Todos = new();
    public Todo(string title)
    {
      Title = title;
      Created = DateTime.Now;
      IsComplete = false;
    }

    public string Title { get; set; }
    public DateTime Created { get; set; }
    public bool IsComplete { get; set; }

    public override string ToString()
    {
      return $"\tTitle: {Title}\n\tCreated At: {Created}\n\tIsComplete: {IsComplete}";
    }

    public static void SerializeAll()
    {
      string jsonString = JsonSerializer.Serialize(Todo.Todos);
      File.WriteAllText("Todos.json", jsonString);
      Console.WriteLine("Saved to file ✅");
    }

    public static void DeserializeAll() 
    {
      var jsonString = File.ReadAllText("Todos.json");
      List<Todo> todoList = JsonSerializer.Deserialize<List<Todo>>(jsonString);
      Todo.Todos = todoList;
    }

  }
}
