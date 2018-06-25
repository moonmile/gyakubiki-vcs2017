using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web444.Models;

namespace web444.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Post(MyModel model)
        {
            ViewBag.Message = "";
            if (string.IsNullOrEmpty(model.Name) ||
                string.IsNullOrEmpty(model.Telephone))
            {
                ViewBag.Message = "名前と電話番号を入力してください";
                return View("Index", model);
            }
            else
            {
                // 結果ページを表示
                return View("Result", model);
            }
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
