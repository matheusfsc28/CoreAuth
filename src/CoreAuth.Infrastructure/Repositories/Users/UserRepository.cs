using CoreAuth.Domain.Entities.Users;
using CoreAuth.Domain.Interfaces.Repositories.Users;
using CoreAuth.Infrastructure.Data;
using CoreAuth.Infrastructure.Repositories.Base;

namespace CoreAuth.Infrastructure.Repositories.Users
{
    public class UserRepository : BaseRepository<User>, IUserReadRepository, IUserWriteRepository
    {
        public UserRepository(CoreAuthDbContext context) : base(context) { }
    }
}
