using System.Threading;
using System.Threading.Tasks;

namespace Pachman.MediatoR.CQRS.Commands
{
    public interface ICommandProcessor
    {
        Task Process(ICommand command, CancellationToken cancellationToken = default);

        Task<TResult> Process<TResult>(
            IResultingCommand<TResult> command,
            CancellationToken cancellationToken = default);
    }
}