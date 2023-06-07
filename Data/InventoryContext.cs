using InveMangSystem.Models;
using Microsoft.EntityFrameworkCore;

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
