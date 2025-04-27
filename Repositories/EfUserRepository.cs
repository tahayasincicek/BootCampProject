using Core.Repositories;
using Entities;
using Infrastructure.Data; 

namespace Repositories
{
    public class EfUserRepository : EfRepositoryBase<User>, IUserRepository
    {
        public EfUserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
