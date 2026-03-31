using CoreAuth.Domain.Interfaces.Security.Tokens;

namespace CoreAuth.Infrastructure.Security.Tokens.Refresh
{
    public class RefreshTokenGeneratorRefreshTokenGenerator : IRefreshTokenGenerator
    {
        public string Generate() => Convert.ToBase64String(Guid.NewGuid().ToByteArray());
    }
}
