using CoreAuth.Domain.Entities.Tokens;
using CoreAuth.Domain.Interfaces.Repositories.Base;

namespace CoreAuth.Domain.Interfaces.Repositories.Tokens
{
    public interface IPasswordResetTokenWriteRepository : IBaseWriteRepository<PasswordResetToken>
    {
    }
}
