using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InveMangSystem.Data;
using InveMangSystem.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace InveMangSystem.Controllers
{
    public class UnitController : Controller
    {
        
        public IActionResult Index()
        {
            List<Unit> units = _context.Units.ToList();

            return View(units);
        }
        private readonly InventoryContext _context;

        public UnitController(InventoryContext context)
        {
            _context = context;
        }
    }
}
