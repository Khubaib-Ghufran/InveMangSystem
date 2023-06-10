using InveMangSystem.Data;
using InveMangSystem.Interfaces;
using InveMangSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InveMangSystem.Repositories
{
    public class UnitRepository:IUnit
    {
        private readonly InventoryContext _context;

        public UnitRepository(InventoryContext context)
        {
            _context = context;
        }

        public Unit Create(Unit unit)
        {
            _context.Units.Add(unit);
            _context.SaveChanges();
            return unit;
        }

        public Unit Delete(Unit unit)
        {
            _context.Units.Attach(unit);
            _context.Entry(unit).State = EntityState.Deleted;
            _context.SaveChanges();
            return unit;
        }

        public Unit Edit(Unit unit)
        {
            _context.Units.Attach(unit);
            _context.Entry(unit).State = EntityState.Modified;
            _context.SaveChanges();
            return unit;
        }

        public List<Unit> GetItems(string SearchText="")
        {
            List<Unit> units = _context.Units.ToList();
            if(SearchText !="" && SearchText !=null)
            {
                units=_context.Units.Where(n=>n.Name.Contains(SearchText)|| n.Description.Contains(SearchText)).ToList();
            }
            else
                units = _context.Units.ToList();

            return units;

        }
        public uint GetUnit()
        {
            throw new NotImplementedException();
        }

        public Unit GetUnit(int id)
        {
           
                Unit unit = _context.Units.FirstOrDefault(u => u.Id == id);
                return unit;
        }


        
    }
}
