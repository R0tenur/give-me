namespace GiveMe.Handlers.Internal
{
    internal record SuccessResult : CommandResult
    {
        public SuccessResult(string message)
        {
            Success = true;
            Message = message;
        }
    }
}