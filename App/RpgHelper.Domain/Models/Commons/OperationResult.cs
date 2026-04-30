namespace RpgHelper.Domain.Models.Commons;

public class OperationResult<T>
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public List<T> Objects { get; set; }
}
