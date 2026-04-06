// Models => Creating a class called TaskItem

namespace TaskTrackerApp.Models
{
    public class TaskItem
    {
        // Title of the task 
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        // The deadline for completing the task
        public DateTime DueDate { get; set; }

        // Status of the task:
        public bool IsCompleted { get; set; }
    }
}
