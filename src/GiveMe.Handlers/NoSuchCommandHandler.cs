using System;
using System.Threading.Tasks;
using GiveMe.Abstractions;
using GiveMe.Abstractions.Commands;
using GiveMe.Commands;
using GiveMe.Handlers.Internal;

namespace GiveMe.Handlers
{
    public class NoSuchCommandHandler : IHandle<NoSuchCommand>
    {
        public Task<ICommandResult> Handle(NoSuchCommand command)
        {
            ICommandResult result = new FailureResult("No such command");
            return Task.FromResult(result);
        }
    }
}
