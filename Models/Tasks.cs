// Define the Task class to represent a task entity.
public class Task
{
    // Unique identifier for each task.
    public int Id { get; set; }

    // Title of the task.
    public string Title { get; set; }

    // Description of the task.
    public string Description { get; set; }

    // Status to indicate if the task is completed.
    public bool IsCompleted { get; set; }
}
