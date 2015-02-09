using System.Diagnostics;

namespace Helper
{
    public class RunApplicationAction : HelperActionBase
    {
        public string FullPathToExecutable { get; set; }

        public RunApplicationAction()
        {
            ActionType = HelperActionTypes.RunApplication;
        }

        protected override bool DoAction()
        {
            try
            {
                var processStartInfo = new ProcessStartInfo(FullPathToExecutable);
                Process.Start(processStartInfo);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
