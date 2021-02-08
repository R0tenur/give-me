using System.Threading.Tasks;
using GiveMe.Abstractions.Commands;

namespace GiveMe.Abstractions
{
    public interface IHandle<in TCommand> where TCommand : ICommand
    {
        Task<ICommandResult> Execute(TCommand command);
    }
}