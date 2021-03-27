using System.Threading;
using System.Threading.Tasks;

namespace Pachman.MediatoR.CQRS.Queries
{
    public interface IQueryService
    {
        Task<TResult> Query<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
    }
}