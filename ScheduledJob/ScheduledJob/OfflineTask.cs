namespace ScheduledJob
{
    internal class OfflineTask
    {
        private readonly NotificationService _notificationService;
        private readonly WorkDataSource _workDataSource;

        public OfflineTask(NotificationService notificationService, WorkDataSource workDataSource)
        {
            _notificationService = notificationService;
            _workDataSource = workDataSource;
        }

        public void DoTask()
        {
            var workItems = _workDataSource.GetPendingWork();
            foreach (var workItem in workItems)
            {
                workItem.DoWork();
                workItem.Completed = true;

                _notificationService.NotifyComplete(workItem);
            }
        }
    }
}
