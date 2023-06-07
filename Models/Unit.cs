using System.ComponentModel.DataAnnotations;

namespace InveMangSystem.Models
{
    public class Unit
    {
        public int Id { get; set; }

        [Required]  
        [StringLength(25)]
        public string Name { get; set; }

        
        [Required]
        [StringLength(50)]
        public string Description { get; set; } 
    }
}
