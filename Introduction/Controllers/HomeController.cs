using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introduction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /*     return Json(new
                 {
                     name ="Farhad",
                     surname="Azadaliyev"
                 });*/


            return View();
        }


        /*public string Test()
        {
            return "salam";
        }*/
    }
}
