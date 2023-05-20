using Microsoft.EntityFrameworkCore;
using Persons.Model;

namespace Persons.DataAccess
{
    public class ProfileDBContext: DbContext
    {

        public ProfileDBContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Person> Persons { set; get; }

        public DbSet<Skill> skills { set; get; }
    }
}
