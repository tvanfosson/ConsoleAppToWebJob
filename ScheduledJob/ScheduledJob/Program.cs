namespace ScheduledJob
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var task = new OfflineTask(new NotificationService(), new WorkDataSource());

            task.DoTask();
        }
    }
}
