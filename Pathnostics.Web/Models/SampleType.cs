using System.ComponentModel.DataAnnotations;

namespace Pathnostics.Web.Models;

public enum SampleType
{
    /// <summary>
    /// Опухоль(целиком)
    /// </summary>
    [Display(Name = "Опухоль(целиком)")]
    TumorWhole,
    
    /// <summary>
    /// Опухоль(фрагмент)
    /// </summary>
    [Display(Name = "Опухоль(фрагмент)")]
    TumorFragment,
    
    /// <summary>
    /// Эндоскопия
    /// </summary>
    [Display(Name = "Эндоскопия")]
    Endoscopy,
    
    /// <summary>
    /// Инцизионная биопсия
    /// </summary>
    [Display(Name = "Инцизионная биопсия")]
    IncisionalBiopsy,
    
    /// <summary>
    /// Трепан-биопсия
    /// </summary>
    [Display(Name = "Трепан-биопсия")]
    TrepanBiopsy,
    
    /// <summary>
    /// Некропсия 
    /// </summary>
    [Display(Name = "Некропсия")]
    Necropsy,
    
    /// <summary>
    /// Аспират
    /// </summary>
    [Display(Name = "Аспират")]
    PhD,
    
    /// <summary>
    /// Соскоб
    /// </summary>
    [Display(Name = "Соскоб")]
    Scraping,
    
    /// <summary>
    /// Мазок отпечаток
    /// </summary>
    [Display(Name = "Мазок отпечаток")]
    SmearImprint,
    
    /// <summary>
    /// Выпот (плевральный, брюшной) 
    /// </summary>
    [Display(Name = "Выпот (плевральный, брюшной)")]
    EffusionPleuralAbdominal,
    
    /// <summary>
    /// ТИБ
    /// </summary>
    [Display(Name = "ТИБ")]
    Tib,
    
    /// <summary>
    /// Лаваж
    /// </summary>
    [Display(Name = "Лаваж")]
    Lavage,
    
    /// <summary>
    /// Готовые стекла
    /// </summary>
    [Display(Name = "Готовые стекла")]
    FinishedGlass,
    
    /// <summary>
    /// Блоки
    /// </summary>
    [Display(Name = "Блоки")]
    Blocks,
    
    /// <summary>
    /// фиксированный (10% формалин)
    /// </summary>
    [Display(Name = "Фиксированный (10% формалин)")]
    Fixed10PercentFormalin,
    
    /// <summary>
    /// Свежий
    /// </summary>
    [Display(Name = "Свежий")]
    Fresh
}