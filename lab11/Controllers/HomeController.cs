using lab11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using lab11.Services;

namespace lab11.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService myservice;
		public HomeController(IMyService service)
		{
			myservice = service;
		}
  
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PassUsingModel()
        { 
            return View(myservice.setModel());
        }

        public IActionResult PassUsingViewData()
        {
            MyModel model= myservice.setModel();
            ViewData["X"] = model.X;
            ViewData["Y"] = model.Y;
            ViewData["add"] = model.add;
			ViewData["sub"] = model.sub;
			ViewData["mul"] = model.mul;
			ViewData["div"] = model.div;
			return View();
		}

		public IActionResult PassUsingViewBag()
		{
			MyModel model = myservice.setModel();
			ViewBag.X = model.X;
			ViewBag.Y = model.Y;
			ViewBag.add = model.add;
			ViewBag.sub = model.sub;
			ViewBag.mul = model.mul;
			ViewBag.div = model.div;
			return View();
		}

		public IActionResult AccessServiceDirectly()
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