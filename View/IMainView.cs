using System;

namespace Helper
{
    public interface IMainView : IView
    {
        void AddAction(IHelperAction action);
        event Action ActionAdded;
        void Perform();
    }
}
