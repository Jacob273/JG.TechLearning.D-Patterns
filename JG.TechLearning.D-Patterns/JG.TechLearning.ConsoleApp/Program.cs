using JG.TechLearning.CQRS.CommandHandlers;
using JG.TechLearning.CQRS.Commands;
using JG.TechLearning.CQRS.Queries;
using JG.TechLearning.CQRS.QueryHandlers;
using JG.TechLearning.DTO;
using JG.TechLearning.ICommon.CQRS;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace JG.TechLearning.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var serviceProvider = IntializeDI();

            var dynamicHandler = serviceProvider.GetService<DynamicHandler>();
            
            dynamicHandler.HandleCommand(command: new AddOrderCommand() { Name = "Order-1" });
            dynamicHandler.HandleQuery<GetOrderQuery, OrderDTO>(query: new GetOrderQuery() { Id = 1 });
        }


        static ServiceProvider IntializeDI()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddTransient<ICommandHandler<AddOrderCommand>, AddOrderCommandHandler>()
                .AddTransient<IQueryHandler<GetOrderQuery, OrderDTO>, GetOrderQueryHandler>()
                .AddTransient<DynamicHandler>()
                .AddLogging(configure => configure.AddConsole())
                .Configure<LoggerFilterOptions>(cfg => cfg.MinLevel = LogLevel.Information)
                .BuildServiceProvider();

            return serviceProvider;
        }

    }
}
