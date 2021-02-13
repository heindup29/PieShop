using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PieShop.Core;
using PieShop.Data;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        public IEnumerable<Pie> Pies { get; set; }

        private readonly ILogger<HomeController> _logger;
        private readonly IPieRepository pieRepository;

        public HomeController(ILogger<HomeController> logger, IPieRepository _pieRepository)
        {
            _logger = logger;
            pieRepository = _pieRepository;
        }

        public IActionResult Index()
        {
            return View(pieRepository.AllPies());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
