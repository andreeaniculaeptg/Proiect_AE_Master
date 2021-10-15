using System.ComponentModel.DataAnnotations;

namespace Puzzle4UbyNAM.Models.DTOs.VM
{
    public class ProductBrandVM
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]        
        public string Name { get; set; }
    }
}
