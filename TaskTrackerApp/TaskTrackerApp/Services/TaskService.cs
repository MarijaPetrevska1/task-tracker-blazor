using TaskTrackerApp.Models;

namespace TaskTrackerApp.Services
{
    // Implements ITaskService 
    public class TaskService : ITaskService
    {
        // In-memory storage for tasks 

        private List<TaskItem> tasks = new List<TaskItem>();

        // Returns all tasks from the in-memory list
        public List<TaskItem> GetAll()
        {
            return tasks;
        }

        // Adds a new task to the list

        public void Add(TaskItem task)
        {
            tasks.Add(task);
        }

        // Removes a task from the list
        public void Delete(TaskItem task)
        {
            tasks.Remove(task);
        }

        // The completion status of a task
        public void ToggleComplete(TaskItem task)
        {
            task.IsCompleted = !task.IsCompleted;
        }
    }
}
