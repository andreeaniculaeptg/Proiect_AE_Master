using Puzzle4UbyNAM.Models.DTOs;
using Puzzle4UbyNAM.Models.DTOs.VM;
using System.Collections.Generic;

namespace Puzzle4UbyNAM.Models.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductVM> GetAllProducts();
        ProductVM GetProduct(int id);
        void AddProduct(ProductVM dto);
        void UpdateProduct(int id, ProductVM dto);
        void DeleteProduct(int id);
        List<IdNameDto> GetProductTypes();
        List<IdNameDto> GetProductBrands();
    }
}
