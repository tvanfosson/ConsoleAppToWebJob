using System;
using System.Threading;

// ReSharper disable ClassWithVirtualMembersNeverInherited.Global because it's an example

namespace ScheduledJob
{
    internal class WorkItem
    {
        private readonly Random _rng = new Random();

        public void DoWork()
        {
            Thread.Sleep(_rng.Next(500) + 1);
        }

        public virtual string NotificationEmail { get; set; }

        public virtual bool Completed { get; set; }
    }
}
