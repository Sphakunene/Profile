using Profile.DataAccess;
using Profile.Interface;
using Profile.Model;

namespace Profile.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ProfileDBContext profileDBContext;

        public GenericRepository(ProfileDBContext _profileDBContext)

        {
            profileDBContext = _profileDBContext;
        }
        public async Task<T> Add(T entity)
        {
            await profileDBContext.Set<T>().AddAsync(entity);
            profileDBContext.SaveChanges();
            return entity;
        }

        public Task<T> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
