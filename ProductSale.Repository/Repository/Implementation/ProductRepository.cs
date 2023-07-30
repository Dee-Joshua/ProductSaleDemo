using Microsoft.EntityFrameworkCore;
using ProductSaleModel.Model;
using ProductSaleRepository.Data;
using ProductSaleRepository.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSaleRepository.Repository.Implementation
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DbSet<Product> _dbSet;
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<Product>();
        }

    }
}
