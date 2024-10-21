using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitMQAPI.Models;

namespace RabbitMQAPI.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAll();

        public Product AddProduct(Product product);

        public bool Delete(int Id);
    }
}