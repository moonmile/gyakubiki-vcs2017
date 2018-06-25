using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web441.Models;

namespace web441.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            var lst = new List<MyModel>();
            lst.Add(new MyModel() { ID = 100, Title = "逆引き大全C#2017", Price = 2000 });
            lst.Add(new MyModel() { ID = 101, Title = "逆引き大全VB2017", Price = 2000 });
            lst.Add(new MyModel() { ID = 102, Title = "逆引き大全F#2017", Price = 2000 });
            return View(lst);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
