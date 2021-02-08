namespace GiveMe.Handlers.Internal
{
    internal record FailureResult : CommandResult
    {
        public FailureResult(string message)
        {
            Success = false;

            Message = message;
        }
    }
}