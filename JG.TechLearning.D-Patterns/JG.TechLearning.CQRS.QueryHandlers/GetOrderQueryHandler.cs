using JG.TechLearning.CQRS.Queries;
using JG.TechLearning.DTO;
using JG.TechLearning.ICommon.CQRS;
using Microsoft.Extensions.Logging;

namespace JG.TechLearning.CQRS.QueryHandlers
{
    public class GetOrderQueryHandler : IQueryHandler<GetOrderQuery, OrderDTO>
    {

        ILogger _logger;

        public GetOrderQueryHandler(ILogger<GetOrderQueryHandler> logger)
        {
            _logger = logger;
        }

        public OrderDTO Handle(IQuery<OrderDTO> query)
        {
            _logger.LogInformation("GetOrderQueryHandler:: getting the order...");

            return new OrderDTO("Order-1");
        }
    }
}
