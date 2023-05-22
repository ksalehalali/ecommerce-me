using Microsoft.AspNetCore.Identity;

namespace ecommerce_webapi.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
