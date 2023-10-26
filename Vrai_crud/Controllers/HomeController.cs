using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vrai_crud.Models;
using Vrai_crud.Context;
using Microsoft.Extensions.Configuration;


using System.Data.SqlClient;
using System.Data;

namespace Vrai_crud.Controllers
{
    public class HomeController : Controller
    {

        dblog dbop = new dblog();
        public IActionResult Login()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Login([Bind] login ad)
        {

            int res = dbop.LoginCheck(ad);
            if (res == 1)
            {
                return RedirectToAction("Index", "Acceuil");

            }
            else
            {
                TempData["msg"] = "mot de passe incorrect";

            }
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
