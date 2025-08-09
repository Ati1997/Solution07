using Microsoft.EntityFrameworkCore;
using MultiPageApplication.Models.DomainModels.ProductAggregates;
using MultiPageApplication.Models.Services.Contracts;

namespace MultiPageApplication.Models.Services.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly MultiPageDbContext _context;

        public ProductRepository(MultiPageDbContext context)
        {
            _context = context; 
        }

        public async Task Delete(Product product)
        {
            using (_context)
            {
                try
                {
                    if (product != null)
                    {
                        _context.Product.Attach(product); // اطمینان از اینکه EF entity رو بشناسه
                        _context.Product.Remove(product);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (_context != null) _context.Dispose();
                }
            }
        }

        public async Task Insert(Product product)
        {
            using (_context)
            {
                try
                {
                    _context.Product.Add(product);
                    await _context.SaveChangesAsync();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (_context != null) _context.Dispose();
                }
            }
        }

        public async Task<List<Product>> SelectAll()
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
                finally { if (_context.Product != null) _context.Dispose(); }
            }
        }

        public async Task<Product> SelectById(Guid id)
        {
            using (_context)
            {
                try
                {
                    return await _context.Product.FirstOrDefaultAsync(p => p.Id == id);


                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (_context != null) _context.Dispose();
                }
            }
        }

        public async Task Update(Product product)
        {
            using (_context)
            {
                try
                {
                    _context.Product.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (_context != null) _context.Dispose();
                }
            }
        }
    }
}
