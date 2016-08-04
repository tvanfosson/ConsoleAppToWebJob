using System.IO;
using Microsoft.Azure.WebJobs;

namespace ConvertedScheduledJob
{
    internal class Functions
    {
        private readonly NotificationService _notificationService;
        private readonly WorkDataSource _workDataSource;

        public Functions()
            : this (new NotificationService(), new WorkDataSource())
        {
            
        }

        public Functions(NotificationService notificationService, WorkDataSource workDataSource)
        {
            _notificationService = notificationService;
            _workDataSource = workDataSource;
        }

        [NoAutomaticTrigger]
        public void Execute(TextWriter log)
        {
            log.WriteLine("starting job");

            var task = new OfflineTask(_notificationService, _workDataSource);

            task.DoTask();

            log.WriteLine("job completed");
        }
    }
}
