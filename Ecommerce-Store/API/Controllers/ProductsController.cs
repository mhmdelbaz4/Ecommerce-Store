using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public ProductsController(StoreContext storeContext)
        {
            this._storeContext = storeContext;
        }


        [HttpGet]
        public IActionResult GetAllProducts()
        {
            IEnumerable<Product> products = _storeContext.Products;

            return Ok(products);  
        }
    }
}
