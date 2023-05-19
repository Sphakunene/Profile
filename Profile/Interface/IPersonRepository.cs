using Profile.Model;

namespace Profile.Interface
{
    public interface IPersonRepository

    {
        Task<Person> Add(Person entity);

        Task<Person> Update(Person entity);

        Task<Person> Delete(Person entity);

        Task<IEnumerable<Person>> GetAll();

        Task<Person> GetById(int id);
    }
}
