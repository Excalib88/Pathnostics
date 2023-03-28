using System.ComponentModel.DataAnnotations;

namespace Pathnostics.Web.Models;

public enum ApplicationStatus
{
    /// <summary>
    /// Создано
    /// </summary>
    [Display(Name = "Создано")]
    Created,
    
    /// <summary>
    /// В обработке
    /// </summary>
    [Display(Name = "В обработке")]
    InProgress,
    
    /// <summary>
    /// Завершено
    /// </summary>
    [Display(Name = "Завершено")]
    Finished
}