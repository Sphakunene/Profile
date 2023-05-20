using Persons.Model;

namespace Persons.Interface
{
    public interface IPersonRepository

    {
        Task<Person> AddAsync(Person person);

        Task<Person> UpdateAsync(Person person);

        Task<Person> DeleteAsync(Person person);

        Task<Person> DeleteByIdAsync(int personId);
   
        Task<IEnumerable<Person>> GetAllAsync();

        Task<Person> GetByIdAsync(int personId);
    }
}
