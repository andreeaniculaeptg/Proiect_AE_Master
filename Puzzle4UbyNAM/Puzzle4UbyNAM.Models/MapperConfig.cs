using AutoMapper;
using Puzzle4UbyNAM.Models.DTOs.VM;
using Puzzle4UbyNAM.Models.Entites;

namespace Puzzle4UbyNAM.Models
{
    public static class MapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductType, ProductTypeVM>();
                cfg.CreateMap<ProductTypeVM, ProductType>();

                cfg.CreateMap<ProductBrand, ProductBrandVM>();
                cfg.CreateMap<ProductBrandVM, ProductBrand>();

                cfg.CreateMap<Product, ProductVM>();
                cfg.CreateMap<ProductVM, Product>();
            });

            return config.CreateMapper();
        }
    }
}
