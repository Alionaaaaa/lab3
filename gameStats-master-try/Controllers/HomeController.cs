using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gameStats.Models;

namespace gameStats.Controllers
{
    public class HomeController : Controller
    {
         public IActionResult Index()
         {
            return View("Index");
         }
    }
}
