using JG.TechLearning.ICommon.CQRS;

namespace JG.TechLearning.CQRS.Commands
{
    public class AddOrderCommand : ICommand
    {
        public string Name { get; set; }
    }
}
