using Microsoft.Extensions.Logging;
using DSharpPlus;
using System;

namespace DiscordBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Bot(
                config: DiscordConfig.Instance,
                logLevel: LogLevel.Info)
                .Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}