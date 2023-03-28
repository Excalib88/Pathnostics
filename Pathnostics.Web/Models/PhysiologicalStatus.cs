using System.ComponentModel.DataAnnotations;

namespace Pathnostics.Web.Models;

public enum PhysiologicalStatus
{
    [Display(Name = "Кастрат")]
    Castrat,
    
    [Display(Name = "Не кастрат")]
    NotCastrat
}