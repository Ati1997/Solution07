using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.Models.DomainModels.ProductAggregates;
using RepositoryDesignPattern.Models.Services.Contracts;
using RepositoryDesignPattern.Sample01.Models.Services;

namespace RepositoryDesignPattern.Models.Services.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineShopDbContext _context;

        public ProductRepository(OnlineShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> Select()
        {
            using (_context)
            {
                try
                {

                    var products = await _context.Product.ToListAsync();
                    return products;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (_context.Product != null) _context.Dispose();
                }
            }
        }
    }
}
