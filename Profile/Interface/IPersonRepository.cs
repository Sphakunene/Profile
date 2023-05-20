using Profile.Model;

namespace Profile.Interface
{
    public interface IPersonRepository

    {
        Task<Person> AddAsync(Person person);

        Task<Person> UpdateAsync(Person person);

        Task<Person> DeleteAsync(Person person);

        Task<Person> DeleteByIdAsync(Person person);
   
        Task<IEnumerable<Person>> GetAllAsync(int personId);

        Task<Person> GetByIdAsync(int personId);
    }
}
