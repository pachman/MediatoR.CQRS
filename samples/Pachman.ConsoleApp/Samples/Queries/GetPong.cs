using System.Threading;
using System.Threading.Tasks;
using Pachman.MediatoR.CQRS.Queries;

namespace Pachman.ConsoleApp.Samples.Queries
{
    public class GetPong : IQuery<string>
    {
    }

    public class GetPongHandler : QueryHandler<GetPong, string>
    {
        public override Task<string> Handle(GetPong query, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong query");
        }
    }
}