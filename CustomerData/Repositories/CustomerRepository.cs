using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerData.Context;
using CustomerData.Models;

namespace CustomerData.Repositories
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
    }

    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerDbContext context) : base(context)
        {
        }
    }
}
