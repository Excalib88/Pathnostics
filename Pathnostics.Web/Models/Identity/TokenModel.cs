namespace Pathnostics.Web.Models.Identity;

public class TokenModel
{
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
}