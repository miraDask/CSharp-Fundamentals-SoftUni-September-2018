using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forum.Models;
using Forum.Data;

namespace Forum.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ForumDbContext context;

        public IActionResult Index()
        {
            return View();
        }
    }
}
