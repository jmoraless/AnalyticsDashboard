namespace AnalyticsDashboard.Models;

/// <summary>
/// DTO para OTS agregados por hora
/// </summary>
public class OtsHourlyDto
{
    /// <summary>Hora del día (0-23)</summary>
    public int Hour { get; set; }

    /// <summary>Total de OTS en esa hora</summary>
    public int TotalOts { get; set; }

    /// <summary>Total de watchers en esa hora</summary>
    public int TotalWatchers { get; set; }
}