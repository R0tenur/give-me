using System.Collections.Generic;
using GiveMe.Abstractions.Commands;

namespace GiveMe.Abstractions
{
    public interface IValidate<in TCommand> where TCommand : ICommand
    {
        IEnumerable<IValidateResult> Validate(TCommand command);
    }
}