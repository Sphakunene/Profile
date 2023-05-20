using System.Runtime.InteropServices;
using Persons.DataAccess;
using Persons.Interface;
using Persons.Model;

namespace Persons.Repository
{
    public class PersonRepository : IPersonRepository
    {

        private readonly ProfileDBContext profileDBContext;

        public PersonRepository(ProfileDBContext _profileDBContext)

        {
            profileDBContext = _profileDBContext;
        }
        public async Task<Person> AddAsync(Person entity)
        {
            await profileDBContext.AddAsync(entity);
            profileDBContext.SaveChanges();
            return entity;
        }

        public Task<Person> DeleteAsync(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdateAsync(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<Person> DeleteByIdAsync(int personId){
            throw new NotImplementedException();
        }
    }
}
