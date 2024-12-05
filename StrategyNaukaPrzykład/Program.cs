using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista zadań
        var tasks = new List<Task>
        {
            new Task { Name = "Task A", Priority = "High", DueDate = DateTime.Now.AddDays(3), IsCompleted = false },
            new Task { Name = "Task B", Priority = "Low", DueDate = DateTime.Now.AddDays(7), IsCompleted = true },
            new Task { Name = "Task C", Priority = "Medium", DueDate = DateTime.Now.AddDays(1), IsCompleted = false },
            new Task { Name = "Task D", Priority = "High", DueDate = DateTime.Now.AddDays(5), IsCompleted = false }
        };

        // Inicjalizacja TaskManagera ze strategią sortowania po priorytecie
        var taskManager = new TaskManager(new PrioritySortingStrategy());

        Console.WriteLine("Sorted by Priority:");
        foreach (var task in taskManager.SortTasks(tasks))
        {
            Console.WriteLine(task);
        }

        // Zmiana strategii sortowania na datę realizacji
        taskManager.SetSortingStrategy(new DueDateSortingStrategy());
        Console.WriteLine("\nSorted by Due Date:");
        foreach (var task in taskManager.SortTasks(tasks))
        {
            Console.WriteLine(task);
        }

        // Zmiana strategii sortowania na nazwę
        taskManager.SetSortingStrategy(new NameSortingStrategy());
        Console.WriteLine("\nSorted by Name:");
        foreach (var task in taskManager.SortTasks(tasks))
        {
            Console.WriteLine(task);
        }
    }
}
