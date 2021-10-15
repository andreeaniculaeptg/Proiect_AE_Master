using AutoMapper;
using Puzzle4UbyNAM.DataAccess.Interfaces;
using Puzzle4UbyNAM.Models.DTOs.VM;
using Puzzle4UbyNAM.Models.Entites;
using Puzzle4UbyNAM.Models.Interfaces;
using System.Collections.Generic;

namespace Puzzle4UbyNAM.Services
{
    public class ProductBrandService : IProductBrandService
    {
        private readonly IRepository<ProductBrand, int> ProductBrandRep;
        private readonly IMapper mapper;

        public ProductBrandService(IRepository<ProductBrand, int> ProductBrandRep, IMapper mapper)
        {
            this.ProductBrandRep = ProductBrandRep;
            this.mapper = mapper;
        }

        public void AddProductBrand(ProductBrandVM dto)
        {
            var entity = mapper.Map<ProductBrand>(dto);
            ProductBrandRep.Add(entity);
        }

        public void DeleteProductBrand(int id)
        {
            var entity = ProductBrandRep.GetInstance(id);
            if (entity == null)
                return;

            ProductBrandRep.Delete(entity);
        }

        public IEnumerable<ProductBrandVM> GetAllProductBrand()
        {
            var products = ProductBrandRep.GetAll();
            return mapper.Map<List<ProductBrandVM>>(products);
        }

        public ProductBrandVM GetProductBrand(int id)
        {
            var entity = ProductBrandRep.GetInstance(id);
            return mapper.Map<ProductBrandVM>(entity);
        }

        public void UpdateProductBrand(int id, ProductBrandVM dto)
        {
            var entity = ProductBrandRep.GetInstance(id);
            if (entity == null)
                return;

            mapper.Map(dto, entity);
            ProductBrandRep.Update(entity);
        }
    }
}
