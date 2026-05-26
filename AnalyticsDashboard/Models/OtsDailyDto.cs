namespace AnalyticsDashboard.Models;

/// <summary>
/// DTO para OTS agregados por día
/// </summary>
public class OtsDailyDto
{
    /// <summary>Fecha del día</summary>
    public DateTime Date { get; set; }

    /// <summary>Total de OTS (oportunidades de ver) del día</summary>
    public int TotalOts { get; set; }

    /// <summary>Total de watchers (personas que realmente vieron) del día</summary>
    public int TotalWatchers { get; set; }

    /// <summary>Porcentaje de conversión (Watchers / OTS * 100)</summary>
    public double WatchRatePercent { get; set; }
}