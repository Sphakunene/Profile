using Profile.DataAccess;
using Profile.Interface;
using Profile.Model;

namespace Profile.Service
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepository _repository;
        

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
            
        }



        public async Task<Person> CreateAsync(Person person)
        {
            
            return await _repository.Add(person);
        }
    }
}
