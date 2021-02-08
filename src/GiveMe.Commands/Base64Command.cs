using GiveMe.Abstractions.Commands;

namespace GiveMe.Commands
{
    public record Base64Command : ICommand
    {
        public string InputData { get; set; }
    }
}
