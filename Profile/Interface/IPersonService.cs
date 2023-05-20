using Persons.dtos;

namespace Persons.Interface
{
    public interface IPersonService
    {
     Task<PersonResponse> CreateAsync(PersonRequest personRequest);
    }
}
