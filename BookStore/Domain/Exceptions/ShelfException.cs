using System.Runtime.Serialization;

namespace BookStore.Domain.Exceptions;

[Serializable]
public class ShelfException : Exception
{
    public ShelfException() : base()
    {
    }

    public ShelfException(string message) : base(message)
    {
    }

    public ShelfException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected ShelfException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        CustomProperty = info.GetString("MyCustomProperty");
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("MyCustomProperty", CustomProperty, typeof(string));
    }

    public string? CustomProperty { get; set; }

    public override string Message => "Custom exception message: " + base.Message;
}