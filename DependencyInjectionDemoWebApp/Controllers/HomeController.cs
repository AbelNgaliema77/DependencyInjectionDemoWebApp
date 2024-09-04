using DependencyInjectionDemoWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ISingletonService _singleton;
        private IScopedService _scoped;
        private ITransientService _transient;
        private IMyService _myService;
        public HomeController(ISingletonService singleton, IScopedService scoped, ITransientService transient, IMyService myService)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
            _myService = myService;
        }

        public IActionResult Index()
        {
            return View("Index", _singleton.GetGuid());
        }

        public IActionResult Scoped()
        {
            return View("Scoped", _scoped.GetGuid());
        }

        public IActionResult Transient()
        {
            return View("Transient", _transient.GetGuid());
        }
    }
}
