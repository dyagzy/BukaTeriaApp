using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BukaTeria.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BukaTeria.Controllers
{
    public class MenuController : Controller
    {
        private readonly IBukaService _bukaService;
        private readonly IMenuService _menuService;

        public MenuController(IBukaService bukaService, IMenuService menuService)
        {
            _bukaService = bukaService;
            _menuService = menuService;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index(int bukaId)
        {
            var buka = await _bukaService.GetbyId(bukaId);
            ViewBag.Title = $"Menus for Buka{buka.BukaName}" + $"{buka.Address}";
            ViewBag.BukaId = bukaId;
            return View(await _menuService.GetAll(bukaId));
        }
    }
}
