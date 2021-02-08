using System;
using System.Threading.Tasks;
using GiveMe.Abstractions;
using GiveMe.Abstractions.Commands;
using GiveMe.Commands;
using GiveMe.Handlers.Internal;
using TextCopy;

namespace GiveMe.Handlers
{
    public class GuidHandler : IHandle<GuidCommand>
    {
        public async Task<ICommandResult> Execute(GuidCommand command)
        {
            await ClipboardService.SetTextAsync(Guid.NewGuid().ToString());
            ICommandResult result = new SuccessResult("Guid added to clipboard");
            return result;
        }
    }
}
