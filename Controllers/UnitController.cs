using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InveMangSystem.Data;
using InveMangSystem.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using InveMangSystem.Interfaces;

namespace InveMangSystem.Controllers
{
    public class UnitController : Controller
    {
        
        public IActionResult Index(string SearchText="",int pageSize=5,int pg=1)
        {
            ViewBag.SearchText = SearchText;
            List<Unit> units = _unitRepo.GetItems(SearchText);//_context.Units.ToList();
            var pager = new PagerModel(units.Count, pg, pageSize);
            this.ViewBag.pager = pager; 
            return View(units);
        }
        
        private readonly IUnit _unitRepo;
        public UnitController(IUnit unitrepo)
        {
            
            _unitRepo = unitrepo;

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
                unit = _unitRepo.Create(unit);

            }

            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            Unit unit =_unitRepo.GetUnit(id);
            return View(unit);
        }

        public IActionResult Edit(int id)
        {
            Unit unit = _unitRepo.GetUnit(id);
            return View(unit);
        }
        [HttpPost]
        public IActionResult Edit(Unit unit)
        {
            try
            {
                unit = _unitRepo.Edit(unit);
            }

            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Unit unit = _unitRepo.GetUnit(id);
            return View(unit);
        }
        [HttpPost]
        public IActionResult Delete(Unit unit)
        {
            try
            {
                unit = _unitRepo.Delete(unit);

            }

            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        
    }
}
