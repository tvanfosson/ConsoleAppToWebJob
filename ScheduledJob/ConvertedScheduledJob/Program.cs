using System.Linq;
using Microsoft.Azure.WebJobs;

namespace ConvertedScheduledJob
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var config = new JobHostConfiguration();

            var host = new JobHost(config);

            var tasks = typeof(Functions).GetMethods()
                                         .Where(m => m.GetCustomAttributes(typeof(NoAutomaticTriggerAttribute), false)
                                                      .Any());
            foreach (var method in tasks)
            {
                host.Call(method);
            }
        }
    }
}
