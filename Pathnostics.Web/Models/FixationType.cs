using System.ComponentModel.DataAnnotations;

namespace Pathnostics.Web.Models;

public enum FixationType
{
    [Display(Name = "Фиксированный (10% формалин)")]
    Fixed10Formalin,
    
    [Display(Name = "Свежий")]
    Fresh
}