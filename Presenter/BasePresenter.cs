namespace Helper
{
    public abstract class BasePresenter<TView> : IPresenter
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController ApplicationController { get; private set; }

        protected BasePresenter(TView view, IApplicationController applicationController)
        {
            View = view;
            ApplicationController = applicationController;
        }

        public void Run()
        {
            View.Open();
        }
    }
}
