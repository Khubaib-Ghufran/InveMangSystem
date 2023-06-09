using InveMangSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace InveMangSystem.Data
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions Options):base(Options)
        {

        }
        public virtual DbSet<Unit> Units { get; set; }
    }

}
