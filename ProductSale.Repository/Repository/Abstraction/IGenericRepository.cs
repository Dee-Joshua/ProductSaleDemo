using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSaleRepository.Repository.Abstraction
{
    public interface IGenericRepository<T>
    {
        Task CreateAsync(T entity);
        void Update(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Remove(T entity);
    }
}
