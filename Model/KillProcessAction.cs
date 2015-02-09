using System.Diagnostics;

namespace Helper
{
    public class KillProcessAction : HelperActionBase
    {
        public string ProcessName { get; set; }

        public KillProcessAction()
        {
            ActionType = HelperActionTypes.KillProcess;
        }

        protected override bool DoAction()
        {
            try
            {
                foreach (var process in Process.GetProcessesByName(ProcessName))
                {
                    process.Kill();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
