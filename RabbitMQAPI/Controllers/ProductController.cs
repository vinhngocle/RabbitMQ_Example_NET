using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMQAPI.Models;
using RabbitMQAPI.Services;

namespace RabbitMQAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return this._productService.GetAll();
        }

        [HttpPost]
        public Product CreateProduct(Product product)
        {
            var result = this._productService.AddProduct(product);

            return result;
        }

    }
}