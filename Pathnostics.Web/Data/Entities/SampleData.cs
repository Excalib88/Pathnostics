using Pathnostics.Web.Models;

namespace Pathnostics.Web.Data.Entities;

public class SampleData : BaseEntity
{
    public DateTime SamplingDate { get; set; }
    public SampleType SampleType { get; set; }
    public string Localization { get; set; } = null!;
    public string LesionDescription { get; set; } = null!;
    public string? Anamnesis { get; set; }
}