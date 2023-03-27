namespace Pathnostics.Web.Data.Entities;

public class CustomerPatient : BaseEntity
{
    public long? CustomerId { get; set; }
    public Customer? Customer { get; set; }
    
    public long? PatientId { get; set; }
    public Patient? Patient { get; set; }
}