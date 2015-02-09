using System.Threading;

namespace Helper
{
    public abstract class HelperActionBase : IHelperAction
    {
        public HelperActionTypes ActionType { get; set; }

        public bool TerminateOnFailure { get; set; }

        public int DelayBefore { get; set; }

        public int DelayAfter { get; set; }

        public int NumberOfAttempts { get; set; }

        public int DelayBetweenAttempts { get; set; }

        public virtual bool Perform()
        {
            if (DelayBefore > 0)
            {
                Thread.Sleep(DelayBefore);
            }

            var attemptsCount = 0;
            bool actionSucceeded;
            do
            {
                actionSucceeded = DoAction();
                Thread.Sleep(DelayBetweenAttempts);
            }
            while (!actionSucceeded && attemptsCount++ < NumberOfAttempts);

            if (DelayAfter > 0)
            {
                Thread.Sleep(DelayAfter);
            }
            return actionSucceeded;
        }

        protected abstract bool DoAction();
    }
}
