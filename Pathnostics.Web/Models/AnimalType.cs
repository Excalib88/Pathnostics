using System.ComponentModel.DataAnnotations;

namespace Pathnostics.Web.Models;

public enum AnimalType
{
    [Display(Name = "Собака")]
    Dog,
    
    [Display(Name = "Кошка")]
    Cat,
    
    [Display(Name = "Грызун")]
    Rodent,
    
    [Display(Name = "Другое")]
    Other
}