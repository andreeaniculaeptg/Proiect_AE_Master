using Microsoft.AspNetCore.Http;
using Puzzle4UbyNAM.Models.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Puzzle4UbyNAM.Models.DTOs.VM
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public int ProductTypeId { get; set; }
        public int ProductBrandId { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductBrandName { get; set; }
        public List<IdNameDto> ProductTypes { get; set; }
        public List<IdNameDto> ProductBrands { get; set; }

        [AllowedExtensions(".jpg", ".png", ".jpeg")]
        [MaxFileSize(3 * 1024 * 1024)]
        public IFormFile ProducImage { get; set; }
    }
}
