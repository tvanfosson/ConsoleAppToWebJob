using System;
using System.Threading;

namespace ConvertedScheduledJob
{
    internal class NotificationService
    {
        private readonly  Random _rng = new Random();

        public void NotifyComplete(WorkItem item)
        {
            Thread.Sleep(_rng.Next(500) + 1);
        }
    }
}
