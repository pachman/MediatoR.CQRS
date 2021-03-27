using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Pachman.MediatoR.CQRS.Commands
{
    public abstract class CommandHandler<TCommand> : AsyncRequestHandler<TCommand> where TCommand : ICommand, IRequest
    {
        protected abstract override Task Handle(TCommand request, CancellationToken cancellationToken);
    }
}