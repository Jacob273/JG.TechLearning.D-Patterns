using JG.TechLearning.CQRS.Commands;
using JG.TechLearning.ICommon.CQRS;
using Microsoft.Extensions.Logging;

namespace JG.TechLearning.CQRS.CommandHandlers
{
    public class AddOrderCommandHandler : ICommandHandler<AddOrderCommand>
    {
        ILogger _logger;
        IValidationHandler<AddOrderCommand> _validator;

        public AddOrderCommandHandler(ILogger<AddOrderCommandHandler> logger, 
                                        IValidationHandler<AddOrderCommand> validator)
        {
            _logger = logger;
            _validator = validator;
        }

        public void Handle(AddOrderCommand command)
        {
            _validator.Validate(command);
            
            //original logic
            _logger.LogInformation("AddOrderCommandHandler:: handling...");
        }
    }
}
