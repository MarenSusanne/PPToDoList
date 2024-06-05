using System.Threading.Tasks;

namespace PPToDoList;

public class ThingsToDo
{
    List<ThingsToDo> tasks = new List<ThingsToDo>();
    public string Name { get; set; }
    public string Description { get; set; }

    public ThingsToDo()
    {

    }

    public ThingsToDo(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void addTask()
    {

        tasks.Add(new ThingsToDo("Laundry", "do laundry"));
        tasks.Add(new ThingsToDo("Clean", "sort living room"));

        foreach (ThingsToDo thingsToDo in tasks)
        {
            Console.WriteLine("This is your tasks:\n" + thingsToDo.Name);
        }
    }

    public void ShowTasks()
    {
        Console.WriteLine("Theese are your tasks that need doing!");
        foreach (ThingsToDo thingsToDo in tasks)
        {
            Console.WriteLine($"\t {thingsToDo.Name}");
        }

    }

    public void AddNewTasks()
    {
        Console.WriteLine("Write the name of your task:");
        var nameResponse = Console.ReadLine();
        Console.WriteLine("Write a description:");
        var descriptionResponse = Console.ReadLine();
        tasks.Add(new ThingsToDo(nameResponse, descriptionResponse));
    }

    public void DeleteTasks()
    {
        Console.WriteLine("Please write the name of the task to remove.");
        var TaskToRemove = Console.ReadLine();
        for (int i = 0; i < tasks.Count; i++)
        {
            if (tasks[i].Name == TaskToRemove)
            {
                tasks.RemoveAt(i);
            }
        }
    }

    public void InfoOnTask()
    {
        bool Exit = true;
        while (Exit)
        {
            Console.WriteLine("write the name of a task to see the description or exit to return to menu.");
            var TaskInfo = Console.ReadLine();
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Name == TaskInfo)
                {
                    Console.WriteLine($"Name of task: {tasks[i].Name}");
                    Console.WriteLine($"Description: {tasks[i].Description}");

                }
                else if (TaskInfo == "exit") { Exit = false; }
            }
        }
    }
}




