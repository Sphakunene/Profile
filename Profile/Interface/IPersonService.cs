using Persons.dtos;
using Persons.Model;

namespace Persons.Interface
{
    public interface IPersonService
    {
     Task<Person>  CreateAsync(Person person);
    }
}
