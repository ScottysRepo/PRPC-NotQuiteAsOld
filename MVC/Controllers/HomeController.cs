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
        // [HttpPost]
        public IActionResult Index()
        {
          //  var model = PRPC.LoginViewModel(userName, passWord);
           // return View(model);
        /* LoginViewModel rec = new LoginViewModel{
               userName = "abc"
           };
            string savedUserName = "abc";
            
            if(userName != savedUserName){
                Console.WriteLine("Invalid username");
            }else if(userName == savedUserName){
                Console.WriteLine("Successful Login");
            }
            ViewData["Message"] = rec;
            */   
            return View();
        }

        public IActionResult ForgotPassword()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Register()
        {
            ViewData["Message"] = "Your register page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

      //  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      //  public IActionResult Error()
       // {
       //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
       // }

        public ActionResult SaveUser(LoginViewModel model, string userName){
            //PRPC  db = new PRPC();

            return View();
        }
    }
}
