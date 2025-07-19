using RepositoryDesignPattern.Models.DomainModels.ProductAggregates;

namespace RepositoryDesignPattern.Models.Services.Contracts
{
    public interface IProductRepository
    {
        Task<List<Product>> Select();
        //Person SelectById(Guid Id);
        //void Insert(Product product);
        //void Update(Product product);
        //void Delete(Guid Id);
    }
}
