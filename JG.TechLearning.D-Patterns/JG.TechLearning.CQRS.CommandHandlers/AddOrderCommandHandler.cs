using JG.TechLearning.CQRS.Commands;
using JG.TechLearning.ICommon.CQRS;
using Microsoft.Extensions.Logging;

namespace JG.TechLearning.CQRS.CommandHandlers
{
    public class AddOrderCommandHandler : ICommandHandler<AddOrderCommand>
    {
        ILogger _logger;
        public AddOrderCommandHandler(ILogger<AddOrderCommandHandler> logger)
        {
            _logger = logger;
        }

        public void Handle(AddOrderCommand command)
        {
            _logger.LogInformation("AddOrderCommandHandler:: handling...");
        }
    }
}
