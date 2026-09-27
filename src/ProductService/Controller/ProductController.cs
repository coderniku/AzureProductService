using Microsoft.AspNetCore.Mvc;
using ProductService.Data;

namespace ProductService.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]       // manadatory otherwise runtime_exception OR Can't be overloaded
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            return Ok(_appDbContext.products.ToList());
        }
    }
}