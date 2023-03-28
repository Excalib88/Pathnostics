using System.ComponentModel.DataAnnotations;

namespace Pathnostics.Web.Models;

public enum Gender
{
    [Display(Name = "Самец")]
    Male,
    
    [Display(Name = "Самка")]
    Female
}