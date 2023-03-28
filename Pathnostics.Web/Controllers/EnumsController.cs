using Microsoft.AspNetCore.Mvc;
using Pathnostics.Web.Data;
using Pathnostics.Web.Extensions;
using Pathnostics.Web.Models;

namespace Pathnostics.Web.Controllers;

[Route("enums")]
public class EnumsController : ApiController
{
    public EnumsController(DataContext dataContext) : base(dataContext)
    {
    }

    [HttpGet("sample-types")]
    public IActionResult GetSampleTypes()
    {
        return Ok(new {sampleTypes = EnumExtensions.GetDisplayNamePairs<SampleType>()});
    }

    [HttpGet("animal-types")]
    public IActionResult GetAnimalTypes()
    {
        return Ok(new {animalTypes = EnumExtensions.GetDisplayNamePairs<AnimalType>() });
    }

    [HttpGet("application-statuses")]
    public IActionResult GetApplicationStatuses()
    {
        return Ok(new {applicationStatues = EnumExtensions.GetDisplayNamePairs<ApplicationStatus>() });
    }
    
    [HttpGet("genders")]
    public IActionResult GetGenders()
    {
        return Ok(new {genders = EnumExtensions.GetDisplayNamePairs<Gender>() });
    }
    
    [HttpGet("physiological-statuses")]
    public IActionResult GetPhysiologicalStatuses()
    {
        return Ok(new {genders = EnumExtensions.GetDisplayNamePairs<PhysiologicalStatus>() });
    }
}