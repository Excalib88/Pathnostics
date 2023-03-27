using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pathnostics.Web.Data;
using Pathnostics.Web.Mappers;
using Pathnostics.Web.Models;

namespace Pathnostics.Web.Controllers;

[Route("applications")]
public class ApplicationsController : ApiController
{
    public ApplicationsController(DataContext dataContext) : base(dataContext)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Create(FullApplicationModel application)
    {
        var result = await DataContext.Applications.AddAsync(application.ToEntity());
        await DataContext.SaveChangesAsync();
        
        return Ok(new {result.Entity.Id});
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var applications = await DataContext.Applications
            .Include(x => x.Clinic)
            .Include(x => x.Customer)
            .Include(x => x.Patient)
            .Include(x => x.SampleData)
            .Include(x => x.User)
            .AsSplitQuery()
            .Select(x => x.ToShortApplication())
            .ToListAsync();

        return Ok(applications);
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> GetById(long id)
    {
        var app = await DataContext.Applications
            .Include(x => x.Clinic)
            .Include(x => x.Customer)
            .Include(x => x.Patient)
            .Include(x => x.SampleData)
            .Include(x => x.User)
            .AsSplitQuery()
            .FirstAsync(x => x.Id == id);
        
        return Ok(app.ToFullApplcation());
    }
}