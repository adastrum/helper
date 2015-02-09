using System.IO;

namespace Helper
{
    public class ReplaceFileAction : HelperActionBase
    {
        public string FullPathFrom { get; set; }
        public string FullPathTo { get; set; }

        public ReplaceFileAction()
        {
            ActionType = HelperActionTypes.ReplaceFile;
        }

        protected override bool DoAction()
        {
            try
            {
                File.Copy(FullPathFrom, FullPathTo, true);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
