using System.Collections.Generic;

namespace Helper
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        private readonly List<IHelperAction> _actions = new List<IHelperAction>();

        public MainPresenter(IMainView view, IApplicationController applicationController)
            : base(view, applicationController)
        {
            View.ActionAdded += AddAction;
        }

        private void AddAction()
        {
            ApplicationController.Run<NewActionPresenter>();
            //todo: получить action из новой формы
            //_actions.Add(action);
            //View.AddAction(action);
        }
    }
}
