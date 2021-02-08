namespace GiveMe.Abstractions.Commands
{
    public interface ICommandResult
    {
        string Message { get; }
        bool Success { get; }
    }
}