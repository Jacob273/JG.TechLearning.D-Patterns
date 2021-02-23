using JG.TechLearning.DTO;
using JG.TechLearning.ICommon.CQRS;

namespace JG.TechLearning.CQRS.Queries
{
    public class GetOrderQuery : IQuery<OrderDTO>
    {
        public int Id { get; set; }
    }
}
