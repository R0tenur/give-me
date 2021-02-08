using System;
using System.Threading.Tasks;

namespace GiveMe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var runner = CommandRunner.Create();

            var result = await runner.RunByArgs(args);

            if (result.Success)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(result.Message);
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
