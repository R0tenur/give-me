using GiveMe.Abstractions.Commands;
namespace GiveMe.Handlers.Internal
{
    internal abstract record CommandResult : ICommandResult
    {
        public string Message { get; protected set; }

        public bool Success { get; protected set; }
    }
}