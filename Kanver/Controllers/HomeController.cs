using Kanver.Data;
using Kanver.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Kanver.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GelenRandevuContext _context;

        public HomeController(ILogger<HomeController> logger,GelenRandevuContext context)
        {

            _logger = logger;
            _context = context;

        }
       

        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Hakkımızda()
        {
            return View();
        }

        public ViewResult Kutuphane()
        {
            return View();
        }
        public ViewResult iletişim()
        {
            return View();
        }
        public ViewResult Randevu(int? Id)
        {
            RandevuKontrol istek;
            if (Id.HasValue)
            {
                istek = _context.RandevuKontrol.Find(Id);
            }
            else
            {
                istek = new RandevuKontrol();
            }
            
            return View(istek);
        }
        
        public ViewResult Konum()
        {
            return View();
        }
    }
}
