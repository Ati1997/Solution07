
using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.Models.DomainModels.PersonAggregates;
using RepositoryDesignPattern.Models.DomainModels.ProductAggregates;


namespace RepositoryDesignPattern.Sample01.Models.Services
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
        {

        }

        public OnlineShopDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person>? Person { get; set; }
        public DbSet<Product>? Product { get; set; }




    }
}
