using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNaukaPrzykład
{
    public class Task
    {
        public required string Name { get; set; }  // Musi być ustawiony przy tworzeniu
        public required string Priority { get; set; }  // Wartości: High, Medium, Low
        public DateTime DueDate { get; set; }  // Termin realizacji zadania
        public bool IsCompleted { get; set; }  // Czy zadanie zostało ukończone
        public List<string> Tags { get; set; } = new();  // Tagowanie zadania

        public Task(string name, string priority, DateTime dueDate, bool isCompleted = false)
        {
            Name = name;
            Priority = priority;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

        public override string ToString()
        {
            return $"{Name} | Priority: {Priority} | Due: {DueDate} | Completed: {IsCompleted}";
        }
    }

}
