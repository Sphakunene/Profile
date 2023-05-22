using Persons.DataAccess;
using Persons.Interface;
using Persons.Model;
using Persons.dtos;
using AutoMapper;

namespace Persons.Service
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;
        

        public PersonService(IPersonRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Person> CreateAsync(Person personRequest)
        {
           // Person person = _mapper.Map<Person>(personRequest);
            await _repository.AddAsync(personRequest);
            //PersonResponse personResponse = _mapper.Map<PersonResponse>(person);
            return personRequest;
        }
    }
}
