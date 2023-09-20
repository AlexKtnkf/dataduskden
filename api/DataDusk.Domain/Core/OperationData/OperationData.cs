namespace DataDusk.Domain;

public class OperationData<T> : IOperationData
{
    private OperationData() { }
    private OperationDataType OperationDataType { get; set; }
    private T? InnerData { get; set; }
    public static OperationData<T> From(T innerData)
    {
        return From(innerData, OperationDataType.Unknown);
    }
    public static OperationData<T> From(T innerData, OperationDataType operationDataType)
    {
        return new OperationData<T>() { InnerData = innerData, OperationDataType = operationDataType };
    }
}