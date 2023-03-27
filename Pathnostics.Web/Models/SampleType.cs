namespace Pathnostics.Web.Models;

public enum SampleType
{
    /// <summary>
    /// Опухоль(целиком)
    /// </summary>
    TumorWhole,
    
    /// <summary>
    /// Опухоль(фрагмент)
    /// </summary>
    TumorFragment,
    
    /// <summary>
    /// Эндоскопия
    /// </summary>
    Endoscopy,
    
    /// <summary>
    /// Инцизионная биопсия
    /// </summary>
    IncisionalBiopsy,
    
    /// <summary>
    /// Трепан-биопсия
    /// </summary>
    TrepanBiopsy,
    
    /// <summary>
    /// Некропсия 
    /// </summary>
    Necropsy,
    
    /// <summary>
    /// Аспират
    /// </summary>
    PhD,
    
    /// <summary>
    /// Соскоб
    /// </summary>
    Scraping,
    
    /// <summary>
    /// Мазок отпечаток
    /// </summary>
    SmearImprint,
    
    /// <summary>
    /// Выпот (плевральный, брюшной) 
    /// </summary>
    EffusionPleuralAbdominal,
    
    /// <summary>
    /// ТИБ
    /// </summary>
    Tib,
    
    /// <summary>
    /// Лаваж
    /// </summary>
    Lavage,
    
    /// <summary>
    /// Готовые стекла
    /// </summary>
    FinishedGlass,
    
    /// <summary>
    /// Блоки
    /// </summary>
    Blocks,
    
    /// <summary>
    /// фиксированный (10% формалин)
    /// </summary>
    Fixed10PercentFormalin,
    
    /// <summary>
    /// Свежий
    /// </summary>
    Fresh
}