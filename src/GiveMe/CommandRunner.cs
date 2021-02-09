using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autofac;
using GiveMe.Abstractions;
using GiveMe.Abstractions.Commands;

namespace GiveMe
{
    public class CommandRunner : ICommandRunner, IDisposable

    {
        private readonly IContainer _diContainer;
        private CommandRunner()
        {
            _diContainer = CommandConfiguration.CreateDiContainer();
        }
        public void Dispose()
        {
            if (_diContainer != null)
            {
                _diContainer.Dispose();
            }
        }

        public static ICommandRunner Create()
        {
            return new CommandRunner();
        }
        public Task<ICommandResult> Handle<TCommand>(TCommand command) where TCommand : ICommand
        {

            var handler = _diContainer.Resolve<IHandle<TCommand>>();

            if (!((handler != null) && handler != null))
            {
                throw new CommandHandlerNotFoundException(typeof(TCommand));
            }

            return handler.Handle(command);
        }

        public IEnumerable<IValidateResult> Validate<TCommand>(TCommand command) where TCommand : ICommand

        {

            var handler = _diContainer.Resolve<IValidate<TCommand>>();

            if (!((handler != null) && handler != null))
            {
                throw new ValidationHandlerNotFoundException(typeof(TCommand));
            }

            return handler.Validate(command);

        }
    }
}