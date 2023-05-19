using Profile.Model;

namespace Profile.Interface
{
    public interface IPersonService
    {
     Task<Person> CreateAsync(Person person );
    }
}
