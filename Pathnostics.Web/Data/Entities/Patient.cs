using Pathnostics.Web.Models;

namespace Pathnostics.Web.Data.Entities;

public class Patient : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Breed { get; set; }
    public int Age { get; set; }
    public Gender Geneder { get; set; }
    public PhysiologicalStatus PhysiologicalStatus { get; set; }
    public AnimalType AnimalType { get; set; }
}