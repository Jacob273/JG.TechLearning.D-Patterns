﻿namespace JG.TechLearning.ICommon.CQRS
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
