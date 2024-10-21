using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using RabbitMQAPI.Models;

namespace RabbitMQAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly DbContextClass _dbContextClass;

        public ProductService(DbContextClass dbContextClass)
        {
            this._dbContextClass = dbContextClass;
        }

        public Product AddProduct(Product product)
        {
            var newProduct = this._dbContextClass.Add(product);
            this._dbContextClass.SaveChanges();

            return newProduct.Entity;
        }

        public IEnumerable<Product> GetAll()
        {
            return this._dbContextClass.Products.ToList();
        }

        public bool Delete(int Id)
        {
            var product = this._dbContextClass.Products.Where(i => i.Id == Id).FirstOrDefault();

            if (product == null)
            {
                throw new ArgumentException("Product not found.");
            }

            this._dbContextClass.Products.Remove(product);

            return true;
        }
    }
}