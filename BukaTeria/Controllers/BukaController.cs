using Buka.Entity;
using BukaTeria.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BukaTeria.Controllers
{
    public class BukaController : Controller

    {
        private readonly IBukaService _bukaService;

        public BukaController(IBukaService bukaService)
        {
            _bukaService = bukaService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Menus";
            return View(await _bukaService.GetAll());

        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Title = "Add Buka";
            return View(new BukaModel());
        }

        [HttpPost]
        public IActionResult Add(BukaModel model)
        {

        }
    }
}
