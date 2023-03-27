using Pathnostics.Web.Data.Entities;
using Pathnostics.Web.Models;

namespace Pathnostics.Web.Mappers;

public static class ApplicationMapper
{
    public static Application ToEntity(this FullApplicationModel app)
    {
        return new Application
        {
            SampleData = new SampleData
            {
                Anamnesis = ""
            }
        };
    }

    public static FullApplicationModel ToFullApplcation(this Application app)
    {
        return new FullApplicationModel();
    }

    public static ShortApplicationModel ToShortApplication(this Application app)
    {
        return new ShortApplicationModel();
    }
}