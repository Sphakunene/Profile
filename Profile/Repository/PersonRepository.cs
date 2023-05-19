using System.Runtime.InteropServices;
using Profile.DataAccess;
using Profile.Interface;
using Profile.Model;

namespace Profile.Repository
{
    public class PersonRepository : IPersonRepository
    {

        private readonly ProfileDBContext profileDBContext;

        public PersonRepository(ProfileDBContext _profileDBContext)

        {
            profileDBContext = _profileDBContext;
        }
        public async Task<Person> Add(Person entity)
        {
            await profileDBContext.AddAsync(entity);
            profileDBContext.SaveChanges();
            return entity;
        }

        public Task<Person> Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
