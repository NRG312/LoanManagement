
namespace LoanManagementApp.Managers
{
    public class MonthChanger
    {
        private CancellationTokenSource cts = new CancellationTokenSource();
        public event EventHandler<OnMonthChangedEvent>? onMonthChanged;

        public int actualMonth { get; private set; }

        public void StartTimer()
        {
            actualMonth = DateTime.Now.Month;
            _ = TaskChanger(cts.Token);
        }
        public async Task TaskChanger(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                int newMonth = DateTime.Now.Month;

                if (actualMonth != newMonth)
                {
                    onMonthChanged?.Invoke(this, new OnMonthChangedEvent(actualMonth, newMonth));

                    actualMonth = newMonth;
                }
                await Task.Delay(TimeSpan.FromHours(1), cancellationToken);
            }
        }
        public void CancelTimer()
        {
            cts.Cancel();
        }
    }


    public class OnMonthChangedEvent
    {
        public int oldMonth { get; }
        public int newMonth { get; }

        public OnMonthChangedEvent(int oldMonth, int newMonth)
        {
            this.oldMonth = oldMonth;
            this.newMonth = newMonth;
        }
    }
}
