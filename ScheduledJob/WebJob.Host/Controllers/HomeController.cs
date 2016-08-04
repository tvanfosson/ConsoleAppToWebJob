using System.Reflection;
using System.Web.Mvc;
using WebJob.Host.Models;

namespace WebJob.Host.Controllers
{
    public class HomeController : Controller
    {
        private static readonly string _version;

        static HomeController()
        {
            var assembly = Assembly.GetExecutingAssembly();
            _version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "Version not set";
        }
        public ActionResult Index()
        {
            return View(new VersionModel { Version = _version });
        }
    }
}