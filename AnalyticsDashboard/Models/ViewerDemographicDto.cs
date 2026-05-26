namespace AnalyticsDashboard.Models;

/// <summary>
/// DTO para distribución demográfica de viewers
/// </summary>
public class ViewerDemographicDto
{
    /// <summary>Género: "Male", "Female", "Unknown"</summary>
    public string Gender { get; set; } = string.Empty;

    /// <summary>Grupo de edad: "Child", "Young Adult", "Adult", "Senior", "Unknown"</summary>
    public string AgeGroup { get; set; } = string.Empty;

    /// <summary>Cantidad de viewers en este grupo</summary>
    public int Count { get; set; }

    /// <summary>Porcentaje del total</summary>
    public double Percentage { get; set; }
}