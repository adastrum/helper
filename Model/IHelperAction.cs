namespace Helper
{
    public interface IHelperAction
    {
        HelperActionTypes ActionType { get; set; }
        bool TerminateOnFailure { get; set; }
        int DelayBefore { get; set; }
        int DelayAfter { get; set; }
        int NumberOfAttempts { get; set; }
        int DelayBetweenAttempts { get; set; }
        bool Perform();
    }

    public enum HelperActionTypes
    {
        KillProcess = 0,
        ReplaceFile = 1,
        RunApplication = 2
    }
}
