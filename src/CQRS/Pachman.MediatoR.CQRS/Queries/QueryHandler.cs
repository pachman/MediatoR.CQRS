using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Pachman.MediatoR.CQRS.Queries
{
    public abstract class QueryHandler<TQuery, TResult> : IRequestHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        public abstract Task<TResult> Handle(TQuery query, CancellationToken cancellationToken);
    }
}