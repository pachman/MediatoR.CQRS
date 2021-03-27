using System;
using System.Threading;
using System.Threading.Tasks;
using Pachman.MediatoR.CQRS.Commands;

namespace Pachman.ConsoleApp.Samples.Commands
{
    public class Ping : ICommand
    {
    }

    public class PingHandler : CommandHandler<Ping>
    {
        protected override Task Handle(Ping request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Pong");

            return Task.CompletedTask;
        }
    }
}