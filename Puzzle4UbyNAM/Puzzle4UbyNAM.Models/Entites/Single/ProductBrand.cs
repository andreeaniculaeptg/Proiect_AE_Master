using System;
using System.Collections.Generic;

#nullable disable

namespace Puzzle4UbyNAM.Models.Entites
{
    public partial class ProductBrand : IEntity<int>
    {
        public ProductBrand()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
