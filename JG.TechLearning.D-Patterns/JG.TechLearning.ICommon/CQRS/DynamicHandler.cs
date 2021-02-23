using System;

namespace JG.TechLearning.ICommon.CQRS
{
    public class DynamicHandler
    {
        private IServiceProvider _serviceProvider;

        public DynamicHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void HandleCommand<TCommand>(TCommand command)
        {
            ThrowIfServiceProviderIsNull();

            var handlerType = typeof(ICommandHandler<>).MakeGenericType(command.GetType());
            dynamic commandHandler = _serviceProvider.GetService(handlerType);
            commandHandler.Handle((dynamic)command);
        }

        public TResult HandleQuery<TQuery, TResult>(TQuery query)
        {
            ThrowIfServiceProviderIsNull();

            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));
            dynamic queryHandler = _serviceProvider.GetService(handlerType);
            return queryHandler.Handle((dynamic)query);
        }

        private void ThrowIfServiceProviderIsNull()
        {
            if (_serviceProvider == null)
            {
                throw new Exception("BaseHandler:: Service provider is null.");
            }
        }
    }
}
