namespace GiveMe.Abstractions.Commands
{
    public interface IValidateResult
    {
        string Message { get; }
        bool Success { get; }
    }
}