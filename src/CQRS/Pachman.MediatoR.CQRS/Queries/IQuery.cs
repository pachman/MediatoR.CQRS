using MediatR;

namespace Pachman.MediatoR.CQRS.Queries
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }
}