namespace DataDusk.Domain;

public class JobSequence
{
    public int Order { get; set; }
    public List<Operation> Operations { get; set; } = new();
    public JobSequenceStatus Status
    {
        get
        {
            if (Operations.Count == 0)
                return JobSequenceStatus.Inactive;

            if (Operations.All(t => t.Status == OperationStatus.Pending))
                return JobSequenceStatus.Pending;

            if (Operations.All(t => t.Status == OperationStatus.Completed))
                return JobSequenceStatus.Completed;

            if (Operations.All(t => t.Status == OperationStatus.Failed))
                return JobSequenceStatus.Failed;

            if (Operations.Any(t => t.Status == OperationStatus.Running))
                return JobSequenceStatus.Running;

            return JobSequenceStatus.PartiallyCompleted;
        }
    }
}