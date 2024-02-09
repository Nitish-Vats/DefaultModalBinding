using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DefaultModalBinding.Models;

namespace DefaultModalBinding.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel post = new PostViewModel()
            {
                id = 1,
                Title = "WhatisASP.NETCore",
                Author = "ShailendraChauhan",
                body = "ASP.NETCoreisanopen-sourceframeworkforbuildingUIandAPI..."
            };
            return View(post);
        }
    }
}
