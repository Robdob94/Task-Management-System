using Microsoft.EntityFrameworkCore;

// Define the database context for managing Task entities.
public class TaskContext : DbContext
{
    // Constructor to configure the DbContext options.
    public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

    // DbSet to represent the collection of Task entities in the database.
    public DbSet<Task> Tasks { get; set; }
}
