using System.Collections.Generic;
using System.Threading.Tasks;
using GiveMe.Abstractions.Commands;

namespace GiveMe.Abstractions
{
    public interface ICommandRunner
    {
        Task<ICommandResult> Handle<TCommand>(TCommand command) where TCommand : ICommand;
        IEnumerable<IValidateResult> Validate<TCommand>(TCommand command) where TCommand : ICommand;
    }
}