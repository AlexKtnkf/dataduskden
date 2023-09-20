namespace DataDusk.Domain;

public enum JobSequenceStatus
{
    Inactive, // No task is configured ?
    Pending,  // No tasks have started
    Running,  // At least one task is running
    Completed,// All tasks have completed successfully
    PartiallyCompleted, // Some tasks have failed, but others completed
    Failed    // All tasks failed
}