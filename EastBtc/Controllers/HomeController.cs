using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Maticsoft.DBUtility;
using static Maticsoft.DBUtility.PubConstant;
using Microsoft.Extensions.Options;

namespace EastBtc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
           string sss= PubConstant.ConnectionString;
            return View();
        }
        private AppSettings AppSettings { get; set; }

        public HomeController(IOptions<AppSettings> settings)
        {
            AppSettings = settings.Value;
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
            return View();
        }
    }
}
