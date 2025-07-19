using RepositoryDesignPattern.ApplicationServices.Dtos;
using RepositoryDesignPattern.Models.DomainModels.ProductAggregates;

namespace RepositoryDesignPattern.ApplicationServices.Services.Contracts
{
    public interface IProductApplicationService
    {
        Task<List<Product>> GetAllAsync();

    }
}
