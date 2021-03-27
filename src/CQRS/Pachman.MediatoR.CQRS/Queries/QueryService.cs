using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Pachman.MediatoR.CQRS.Queries
{
    public class QueryService : IQueryService
    {
        private readonly IMediator _mediator;

        public QueryService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<TResult> Query<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            return _mediator.Send(query, cancellationToken);
        }
    }
}