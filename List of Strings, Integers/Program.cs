using System;
using System.Collections.Generic;

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public Task(string title, string description, DateTime duedate)
    {
        Title=title;
        Description=description;
        DueDate=duedate;

    }
}

public class TaskManager
{
    private List<Task> tasks= new List<Task>();

    public void AddTask(string title, string description, DateTime duedate)
    {
        tasks.Add(new Task(title, description, duedate));
        Console.WriteLine("Task added.");
        Console.WriteLine();
    }

    public void ViewTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine();  
            Console.WriteLine($"Name: {task.Title} \nDescription: {task.Description} \nDueDate: {task.DueDate}");
            
        }
        Console.WriteLine();
    }


    public void RemoveTask(string title)
    {
        Task taskToRemove = tasks.Find(task => task.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
            Console.WriteLine($"Task '{title}' removed.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Task with title '{title}' not found.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {


        TaskManager taskmanager = new TaskManager();

        while(true)
        {
            Console.Write("Task Manager Menu: ");
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Add new task to Task Manager");
            Console.WriteLine("2. Remove task from Task Manager");
            Console.WriteLine("3. View tasks in Task Manager");
            Console.WriteLine("4. Quit Program");

            string selection = Console.ReadLine();



            switch (selection)
            {
                case "1":
                        Console.WriteLine();
                        Console.WriteLine("Enter task title: ");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter task description: ");
                        string description = Console.ReadLine();

                        Console.WriteLine("Enter task duedate e.g. 07-10-2023: ");
                        DateTime duedate = DateTime.Parse(Console.ReadLine());

                        taskmanager.AddTask(title, description, duedate);
                    break;

                case "2":
                        Console.WriteLine("Enter title of the task you want to remove: ");
                        string tasktoremove=Console.ReadLine();
                        taskmanager.RemoveTask(tasktoremove);
                    break;


                case "3":
                        Console.WriteLine();
                        taskmanager.ViewTasks();
                    break;

                case "4":
                        Console.WriteLine();
                        Console.WriteLine("Bye!");
                    return;

                default:
                        Console.WriteLine("Invalid input - Try again");
                    break;
            }
        }
    }  

}