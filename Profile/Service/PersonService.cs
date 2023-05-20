using Profile.DataAccess;
using Profile.Interface;
using Profile.Model;

namespace Profile.Service
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

        public async Task<PersonResponse> CreateAsync(PersonRequest personRequest)
        {
            Person person = _mapper.Map<Person>(personRequest);
            await _repository.AddAsync(person);
            PersonResponse = _mapper.Map<PersonRequest>(PersonResponse);
            return PersonResponse;
        }
    }
}
