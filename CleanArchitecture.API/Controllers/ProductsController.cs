using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.Services;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            return product == null ? (IActionResult) NotFound() : Ok(product);
        }
    }
}