using RepositoryDesignPattern.ApplicationServices.Services.Contracts;
using RepositoryDesignPattern.Models.DomainModels.PersonAggregates;
using RepositoryDesignPattern.Models.Services.Contracts;

namespace RepositoryDesignPattern.ApplicationServices.Services
{
    public class PersonApplicationService : IPersonApplicationService
    {
        private readonly IPersonRepository _personRepository;

        public PersonApplicationService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Task<List<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
