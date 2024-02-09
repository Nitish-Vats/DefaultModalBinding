using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultModalBinding.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
