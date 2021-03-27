using System.Threading;
using System.Threading.Tasks;
using Pachman.MediatoR.CQRS.Commands;

namespace Pachman.ConsoleApp.Samples.Commands
{
    public class PingResulting : IResultingCommand<string>
    {
    }

    public class PingResultingHandler : ResultingCommandHandler<PingResulting, string>
    {
        public override Task<string> Handle(PingResulting request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong resulting");
        }
    }
}