using Microsoft.AspNetCore.Mvc;
using PieShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Controllers
{
    public class DescriptionController : Controller
    {
        private readonly IPieRepository pieRepository;

        public DescriptionController(IPieRepository _pieRepository)
        {
            pieRepository = _pieRepository;
        }
        [HttpGet]
        public IActionResult Info(int id)
        {
            var pie = pieRepository.PieById(id);
            if (pie == null)
            {
                return RedirectToPage("IdNotFound");
            }
            else
            {
                return View(pie);
            }
            
        }
    }
}
