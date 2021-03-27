using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Pachman.MediatoR.CQRS.Commands
{
    public class CommandProcessor : ICommandProcessor
    {
        private readonly IMediator _mediator;

        public CommandProcessor(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task Process(ICommand command, CancellationToken cancellationToken = default)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            return _mediator.Send(command, cancellationToken);
        }

        public Task<TResult> Process<TResult>(
            IResultingCommand<TResult> command,
            CancellationToken cancellationToken = default)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            return _mediator.Send((IRequest<TResult>) command, cancellationToken);
        }
    }
}