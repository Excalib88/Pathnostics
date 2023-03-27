using Microsoft.AspNetCore.Mvc;
using Pathnostics.Web.Data;

namespace Pathnostics.Web.Controllers;

[ApiController]
public class ApiController : ControllerBase
{
    public ApiController(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public readonly DataContext DataContext;
}