using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanver.Controllers
{
    public class BookControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

     
    }
}
