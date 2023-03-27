using Microsoft.AspNetCore.Identity;
using Pathnostics.Web.Data.Entities;

namespace Pathnostics.Web.Services.Identity;

public interface ITokenService
{
    string CreateToken(ApplicationUser user, List<IdentityRole<long>> role);
}