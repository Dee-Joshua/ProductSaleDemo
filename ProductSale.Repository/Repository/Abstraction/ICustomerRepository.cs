using ProductSaleModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSaleRepository.Repository.Abstraction
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();

        Task<Customer> GetCustomerById(int id);
    }
}
