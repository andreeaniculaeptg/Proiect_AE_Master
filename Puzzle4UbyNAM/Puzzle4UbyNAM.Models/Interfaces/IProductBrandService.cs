using Puzzle4UbyNAM.Models.DTOs.VM;
using System.Collections.Generic;

namespace Puzzle4UbyNAM.Models.Interfaces
{
    public interface IProductBrandService
    {
        IEnumerable<ProductBrandVM> GetAllProductBrand();
        ProductBrandVM GetProductBrand(int id);
        void AddProductBrand(ProductBrandVM dto);
        void UpdateProductBrand(int id, ProductBrandVM dto);
        void DeleteProductBrand(int id);
    }
}
