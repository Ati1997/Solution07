using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.Models.DomainModels.PersonAggregates;
using RepositoryDesignPattern.Models.Services.Contracts;
using RepositoryDesignPattern.Sample01.Models.Services;

namespace RepositoryDesignPattern.Models.Services.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly OnlineShopDbContext _context;

        public PersonRepository(OnlineShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<Person>> Select()
        {
            using (_context)
            {
                try
                {

                    var persons = await _context.Person.ToListAsync();
                    return persons;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (_context.Person != null) _context.Dispose();

                }
            }
        }
    }
}