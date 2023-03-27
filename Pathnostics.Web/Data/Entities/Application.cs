using Pathnostics.Web.Models;

namespace Pathnostics.Web.Data.Entities;

public class Application : BaseEntity
{
    public string? SampleNumber { get; set; }
    public DateTime? ReceivedAt { get; set; }
    public int CassettesCount { get; set; }
    public int FragmentCount { get; set; }
    public ApplicationStatus Status { get; set; } = ApplicationStatus.Created;
    
    public long? PatientId { get; set; }
    public Patient? Patient { get; set; }
    
    public long? CustomerId { get; set; }
    public Customer? Customer { get; set; }
    
    public long? ClinicId { get; set; }
    public Clinic? Clinic { get; set; }
    
    public long? SampleDataId { get; set; }
    public SampleData? SampleData { get; set; }
    
    public long? UserId { get; set; }
    public ApplicationUser? User { get; set; }
}