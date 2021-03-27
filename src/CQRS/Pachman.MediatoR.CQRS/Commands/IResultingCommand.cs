using MediatR;

namespace Pachman.MediatoR.CQRS.Commands
{
    public interface IResultingCommand<out TResult> : IRequest<TResult>
    {
    }
}