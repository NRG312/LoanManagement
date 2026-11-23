
namespace LoanManagementApp.Managers
{
    internal class SaveTimer
    {
        private CancellationTokenSource cts = new CancellationTokenSource();
        public event Action? SaveAction;

        public void StartTimer()
        {
            _ = TaskSaver(cts.Token);
        }

        public async Task TaskSaver(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromHours(1), cts.Token);
                SaveAction?.Invoke();
            }
        }
        public void CancelToken()
        {
            cts.Cancel();
        }
    }
}
