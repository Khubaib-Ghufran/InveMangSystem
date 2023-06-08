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

        public IActionResult Create()
        {
            Unit unit = new Unit();
           return View(unit);
        }
        [HttpPost]
        public IActionResult Create(Unit unit)
        {
            try
            {
                _context.Units.Add(unit);
                _context.SaveChanges();

            }

            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            Unit unit =GitUnit(id);
            return View(unit);
        }

        public IActionResult Edit(int id)
        {
            Unit unit = GitUnit(id);
            return View(unit);
        }
        [HttpPost]
        public IActionResult Edit(Unit unit)
        {
            try
            {
                _context.Units.Attach(unit);
                _context.Entry(unit).State=EntityState.Modified;
                _context.SaveChanges();
            }

            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        private Unit GitUnit(int id)
        {
            Unit unit = _context.Units.FirstOrDefault(u => u.Id == id);
            return unit;
        }
    }
}
