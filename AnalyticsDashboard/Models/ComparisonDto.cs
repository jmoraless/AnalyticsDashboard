namespace AnalyticsDashboard.Models;

/// <summary>
/// DTO para comparativa OTS vs Watchers
/// </summary>
public class ComparisonDto
{
    /// <summary>Período (día)</summary>
    public DateTime Period { get; set; }

    /// <summary>Cantidad de OTS</summary>
    public int OtsCount { get; set; }

    /// <summary>Cantidad de watchers</summary>
    public int WatcherCount { get; set; }

    /// <summary>Diferencia (OTS - Watchers)</summary>
    public double Difference { get; set; }

    /// <summary>Porcentaje de conversión</summary>
    public double ConversionRatePercent { get; set; }
}