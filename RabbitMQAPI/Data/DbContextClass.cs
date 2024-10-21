using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RabbitMQAPI.Models;

namespace Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

}