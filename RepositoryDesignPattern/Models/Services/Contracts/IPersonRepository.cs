using RepositoryDesignPattern.Models.DomainModels.PersonAggregates;

namespace RepositoryDesignPattern.Models.Services.Contracts
{
    public interface IPersonRepository
    {
        Task<List<Person>> Select();
        //Person SelectById(Guid Id);
        //void Insert(Person person);
        //void Update(Person person);
        //void Delete(Guid Id);

    }
}
