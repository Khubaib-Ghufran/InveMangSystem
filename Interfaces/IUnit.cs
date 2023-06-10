using InveMangSystem.Models;
using System.Collections.Generic;
using InveMangSystem.Interfaces;

namespace InveMangSystem.Interfaces
{
    public interface IUnit
    {
       
            List<Unit> GetItems(string SearchText=" ");
            Unit GetUnit(int id);
            Unit Create(Unit unit);
            Unit Edit(Unit unit);
            Unit Delete(Unit unit);



    }
}
