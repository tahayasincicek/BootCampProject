using Core.Repositories;
using Entities;

namespace Repositories
{
    public interface IUserRepository : IAsyncRepository<User>
    {
    }
}
