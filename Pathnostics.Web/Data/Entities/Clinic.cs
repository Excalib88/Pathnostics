namespace Pathnostics.Web.Data.Entities;

public class Clinic : BaseEntity
{
    public string Name { get; set; } = null!;
    public string DoctorName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
}