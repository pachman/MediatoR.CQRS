using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Pachman.MediatoR.CQRS.Commands
{
    public abstract class ResultingCommandHandler<TCommand, TResult> : IRequestHandler<TCommand, TResult>
        where TCommand : IResultingCommand<TResult>
    {
        public abstract Task<TResult> Handle(TCommand request, CancellationToken cancellationToken);
    }
}