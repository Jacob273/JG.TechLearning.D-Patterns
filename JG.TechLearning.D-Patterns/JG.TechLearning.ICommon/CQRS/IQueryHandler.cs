namespace JG.TechLearning.ICommon.CQRS
{
    public interface IQueryHandler<TQuery, TQueryResult> where TQuery : IQuery<TQueryResult>
    {
        TQueryResult Handle(IQuery<TQueryResult> query);
    }
}
