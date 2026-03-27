using CoreAuth.Domain.Entities.Users;
using CoreAuth.Domain.Interfaces.Repositories.Base;

namespace CoreAuth.Domain.Interfaces.Repositories.Users
{
    public interface IUserReadRepository : IBaseReadRepository<User>
    {
    }
}
