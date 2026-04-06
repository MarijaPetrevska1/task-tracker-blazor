using TaskTrackerApp.Models;

namespace TaskTrackerApp.Services
{
    // Interface
    // Any service that manages tasks must implement this interface
    // Returns a list of tasks, add new task, delete a task and toggles the completion status of a task
    public interface ITaskService
    {
        List<TaskItem> GetAll();
        void Add(TaskItem task);
        void Delete(TaskItem task);
        void ToggleComplete(TaskItem task);
    }
}
