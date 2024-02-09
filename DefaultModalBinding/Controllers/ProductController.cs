using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultModalBinding.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string name) //bound for query string
        {
            return View();
        }
    }
}
