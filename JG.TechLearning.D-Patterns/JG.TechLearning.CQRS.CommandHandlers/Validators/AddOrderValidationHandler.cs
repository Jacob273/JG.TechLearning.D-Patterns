using JG.TechLearning.CQRS.Commands;
using JG.TechLearning.ICommon.CQRS;
using Microsoft.Extensions.Logging;
using System;

namespace JG.TechLearning.CQRS.CommandHandlers.Validators
{
    public class AddOrderValidationHandler : IValidationHandler<AddOrderCommand>
    {
        ILogger _logger;
        public AddOrderValidationHandler(ILogger<AddOrderValidationHandler> logger)
        {
            _logger = logger;
        }

        public void Validate(AddOrderCommand command)
        {
            _logger.LogInformation("AddOrderValidationHandler:: Validating order...");
            if (string.IsNullOrEmpty(command.Name))
            {
                throw new Exception("Order name is incorrect.");
            }
        }
    }
}
