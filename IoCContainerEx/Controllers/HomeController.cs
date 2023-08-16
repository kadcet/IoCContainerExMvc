using IoCContainerEx.Models;
using IoCContainerEx.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IoCContainerEx.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService singletonService;
        private readonly IScopedService scopedService;
        private readonly ITransientService transientService;
        private readonly OperationService operationService;

        public HomeController(ISingletonService singletonService,IScopedService scopedService,ITransientService transientService,OperationService operationService)
        {
            this.singletonService = singletonService;
            this.scopedService = scopedService;
            this.transientService = transientService;
            this.operationService = operationService;
        }

        

        public IActionResult Index()
        {
            ViewBag.Singleton = singletonService;
            ViewBag.Scoped=scopedService;
            ViewBag.Transient=transientService;

            ViewBag.OperationService=operationService;






            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}