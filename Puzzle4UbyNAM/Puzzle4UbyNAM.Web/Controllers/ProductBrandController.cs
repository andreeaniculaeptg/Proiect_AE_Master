using Microsoft.AspNetCore.Mvc;
using Puzzle4UbyNAM.Models.DTOs.VM;
using Puzzle4UbyNAM.Models.Interfaces;

namespace Puzzle4UbyNAM.Web.Controllers
{
    [Route("[Controller]")]
    public class ProductBrandController : Controller
    {
        private readonly IProductBrandService service;

        public ProductBrandController(IProductBrandService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = service.GetAllProductBrand();
            return View(list);
        }

        [HttpGet]
        [Route("New")]
        public IActionResult New()
        {
            var dto = new ProductBrandVM();
            return View(dto);
        }

        [HttpPost]
        [Route("New")]
        public IActionResult New(ProductBrandVM dto)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some errors in your form");
                return View(dto);
            }

            service.AddProductBrand(dto);

            return View("Index", service.GetAllProductBrand());
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var dto = service.GetProductBrand(id);
            return View(dto);
        }

        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id, ProductBrandVM dto)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some errors in your form");
                return View(dto);
            }

            service.UpdateProductBrand(id, dto);

            return View("Index", service.GetAllProductBrand());
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public JsonResult Delete(int id)
        {
            service.DeleteProductBrand(id);
            return Json(new { success = true, message = "Delete success" });
        }
    }
}
