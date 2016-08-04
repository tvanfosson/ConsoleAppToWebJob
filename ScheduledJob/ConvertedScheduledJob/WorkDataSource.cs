using System.Collections.Generic;

namespace ConvertedScheduledJob
{
    internal class WorkDataSource
    {
        public IEnumerable<WorkItem> GetPendingWork()
        {
            for (var i = 0; i < 30; ++i)
            {
                yield return new WorkItem
                {
                    NotificationEmail = $"example{i}@example.com"
                };
            }
        }
    }
}
