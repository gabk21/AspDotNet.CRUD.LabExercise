using CustomerData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Context
{
    public class CustomerDbContext: DbContext
    {
        private readonly string connectionString;

        public CustomerDbContext(): this("Server=7LMBQG3;Database=CustomerDb;User Id=sa;Password=invoker21")
        {

        }

        public CustomerDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(this.connectionString);
            }
        }
    }
}