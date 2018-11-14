using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PRPC.Models;


namespace PRPC.Controllers
{
    public class HomeController : Controller
    {
         
        public IActionResult Index()
        {
            string savedUserName = "abc";
            string userName {get; set;}
            if(userName != savedUserName){
                Console.WriteLine("Invalid username");
            }else if(userName == savedUserName){
                Console.WriteLine("Successful Login");
            }
            return View();
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult SaveUser(LoginViewModel model, string userName){
            //PRPC  db = new PRPC();

            return View();
        }
    }
}
