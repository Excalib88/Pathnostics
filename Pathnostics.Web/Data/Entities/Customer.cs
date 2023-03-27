namespace Pathnostics.Web.Data.Entities;

public class Customer : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
}