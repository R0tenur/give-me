using System.Linq;
using System.Threading.Tasks;
using Autofac;
using GiveMe.Abstractions;
using GiveMe.Abstractions.Commands;
using GiveMe.Commands;
using GiveMe.Handlers;

namespace GiveMe
{
    public class CommandConfiguration
    {
        public static IContainer CreateDiContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GuidHandler>().As<IHandle<GuidCommand>>();
            builder.RegisterType<Base64Handler>().As<IHandle<Base64Command>>();
            builder.RegisterType<NoSuchCommandHandler>().As<IHandle<NoSuchCommand>>();

            return builder.Build();
        }
    }

    public static class CommandRunnerExtensions
    {
        public static Task<ICommandResult> RunByArgs(this ICommandRunner commandRunner, string[] args)
        {
            var command = args.FirstOrDefault();

            return command switch
            {
                "guid" => commandRunner.Handle(new GuidCommand()),
                "base64" => commandRunner.Handle(new Base64Command
                {
                    InputData = args.Skip(1).FirstOrDefault()
                }),
                _ => commandRunner.Handle(new NoSuchCommand())
            };
        }
    }
}