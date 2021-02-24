namespace JG.TechLearning.ICommon.CQRS
{
    public interface IValidationHandler<TCommand> where TCommand : ICommand
    {
        void Validate(TCommand command);
    }
}
