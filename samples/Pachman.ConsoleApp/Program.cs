using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Pachman.ConsoleApp.Samples.Commands;
using Pachman.ConsoleApp.Samples.Queries;
using Pachman.MediatoR.CQRS.Commands;
using Pachman.MediatoR.CQRS.Queries;

namespace Pachman.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddMediatR(typeof(Ping));
            services.AddSingleton<ICommandProcessor, CommandProcessor>();
            services.AddSingleton<IQueryService, QueryService>();

            var provider = services.BuildServiceProvider();
            var commandProcessor = provider.GetService<ICommandProcessor>();
            var queryService = provider.GetService<IQueryService>();
            await commandProcessor.Process(new Ping());

            Console.WriteLine(await commandProcessor.Process(new PingResulting()));
            Console.WriteLine(await queryService.Query(new GetPong()));
        }
    }
}