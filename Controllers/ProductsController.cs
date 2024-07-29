using InMemory.Models;
using InMemory.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InMemory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
            private readonly ProductRepository productRepository;

            public ProductsController()
            {
                productRepository = new ProductRepository();
            }

            // GET: api/products
            [HttpGet]
            public ActionResult<IEnumerable<Products>> GetProducts()
            {
                var products = productRepository.GetAllProducts();
                return Ok(products);
            }

            // GET: api/products/1
            [HttpGet("{id}")]
            public ActionResult<Products> GetProduct(int id)
            {
                var product = productRepository.GetProductById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }

    }
}
