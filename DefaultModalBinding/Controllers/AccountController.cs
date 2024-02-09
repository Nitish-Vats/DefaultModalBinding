using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DefaultModalBinding.Models;

namespace DefaultModalBinding.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserViewModal model)
        {
            if(model.Username== "admin@gmail.com" && model.Password=="12345678")
            {
                return RedirectToAction("Index","Home",new { Area="Admin"});
            }
            else if(model.Username== "user@gmail.com" && model.Password == "12345678")
            {
               return RedirectToAction("Index", "Account", new { Area = "User" });;
            }
            return View();

        }


        public IActionResult LogOut()
        {
            return View();
        }

    }
}
