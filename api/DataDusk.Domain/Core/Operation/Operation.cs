namespace DataDusk.Domain;
public class Operation : IOperation
{
    public Guid OperationId { get; set; } = Guid.NewGuid();
    public OperationType OperationType { get; set; }
    public List<IOperationData> InputData { get; set; } = new();
    public List<IOperationData> OutputData { get; set; } = new();

    public Dictionary<string, object> Configuration { get; set; } = new();

    public OperationStatus Status { get; set; } = OperationStatus.Pending;
}