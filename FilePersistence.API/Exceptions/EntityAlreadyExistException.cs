namespace FilePersistence.API.Exceptions;

public class EntityAlreadyExistException : Exception
{
    public EntityAlreadyExistException()
    {
    }

    public EntityAlreadyExistException(string message) : base(message)
    {
    }

    public EntityAlreadyExistException(string message, Exception innerException) : base(message, innerException)
    {
    }
}