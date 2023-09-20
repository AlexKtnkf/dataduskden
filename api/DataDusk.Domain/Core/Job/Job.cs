namespace DataDusk.Domain;
public class Job
{
    public Guid JobId { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }

    public List<JobSequence> JobSequences { get; set; } = new();

    public JobStatus Status
    {
        get
        {
            if (JobSequences.Count == 0
            || JobSequences.All(t =>    
                new[] {
                    JobSequenceStatus.Pending,
                    JobSequenceStatus.Inactive }
                .Contains(t.Status)))
                return JobStatus.Pending;

            if (JobSequences.All(t => t.Status == JobSequenceStatus.Completed))
                return JobStatus.Completed;

            if (JobSequences.All(t => t.Status == JobSequenceStatus.Failed))
                return JobStatus.Failed;

            if (JobSequences.Any(t => t.Status == JobSequenceStatus.Running))
                return JobStatus.Running;

            return JobStatus.PartiallyCompleted;
        }
    }
}
