using RepositoryDesignPattern.ApplicationServices.Dtos;
using RepositoryDesignPattern.Models.DomainModels.PersonAggregates;
using RepositoryDesignPattern.Models.DomainModels.ProductAggregates;

namespace RepositoryDesignPattern.ApplicationServices.Services.Contracts
{
    public interface IPersonApplicationService
    {
        Task<List<Person>> GetAllAsync();

    }
}
