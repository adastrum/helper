namespace Helper
{
    public class NewActionPresenter : BasePresenter<INewActionView>
    {
        public NewActionPresenter(INewActionView view, IApplicationController applicationController)
            : base(view, applicationController)
        {
        }
    }
}
