using Core.Repositories;
using Entities;

namespace Repositories
{
    public interface IEmployeeRepository : IAsyncRepository<Employee>
    {
    }
}
