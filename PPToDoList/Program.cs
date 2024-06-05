// Lag en to do app! Du skal kunne legge til oppgaver, slette dem og gå inn på en task for å se beskrivelse eller flere detaljer
// List m/oppgaver
using PPToDoList;
ThingsToDo newTask = new ThingsToDo();
Main();

void Main()
{
    while (true) {
    Console.Clear();
    newTask.ShowTasks();
    Console.WriteLine("\nOptions:");
    Console.WriteLine("1. Add a new Task to your list!");
    Console.WriteLine("2. Remove a task from your list!");
    Console.WriteLine("3. Read more info on the task");

    string Response = Console.ReadLine();
    int Check = Convert.ToInt32(Response);

        switch (Check)
        {
            case 1:
                newTask.AddNewTasks();
                break;
            case 2:
                newTask.DeleteTasks();
                break;
            case 3:
                newTask.InfoOnTask();
                break;
            default:
                Console.WriteLine("Please input a valid option!");
                break;
        }

    }

}