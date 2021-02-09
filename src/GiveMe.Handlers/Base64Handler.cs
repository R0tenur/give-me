using System;
using System.Text;
using System.Threading.Tasks;
using GiveMe.Abstractions;
using GiveMe.Abstractions.Commands;
using GiveMe.Commands;
using GiveMe.Handlers.Internal;
using TextCopy;

namespace GiveMe.Handlers
{
    public class Base64Handler : IHandle<Base64Command>
    {
        public async Task<ICommandResult> Handle(Base64Command command)
        {
            string data = command.InputData;
            if (string.IsNullOrWhiteSpace(data))
            {
                data = await ClipboardService.GetTextAsync();
            }

            await ClipboardService.SetTextAsync(ToBase64String(data));
            ICommandResult result = new SuccessResult("the base64 is added to clipboard");
            return result;
        }

        private string ToBase64String(string text)
        {
            var bytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }
    }
}
