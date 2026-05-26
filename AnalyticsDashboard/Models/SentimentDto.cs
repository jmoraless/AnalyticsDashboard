namespace AnalyticsDashboard.Models;

/// <summary>
/// DTO para análisis de sentimiento
/// </summary>
public class SentimentDto
{
    /// <summary>Sentimiento promedio general</summary>
    public string AverageSentiment { get; set; } = string.Empty;

    /// <summary>Porcentaje de viewers felices (Happy + VeryHappy)</summary>
    public double HappyRate { get; set; }

    /// <summary>Porcentaje de viewers neutrales</summary>
    public double NeutralRate { get; set; }

    /// <summary>Porcentaje de viewers infelices (Unhappy + VeryUnhappy)</summary>
    public double UnhappyRate { get; set; }

    /// <summary>Desglose detallado por tipo de sentimiento</summary>
    public SentimentBreakdownDto Breakdown { get; set; } = new();

    /// <summary>Tendencia diaria de sentimiento</summary>
    public List<DailySentimentDto> DailyTrend { get; set; } = new();
}

/// <summary>
/// Desglose detallado de sentimientos
/// </summary>
public class SentimentBreakdownDto
{
    public double VeryHappy { get; set; }
    public double Happy { get; set; }
    public double Neutral { get; set; }
    public double Unhappy { get; set; }
    public double VeryUnhappy { get; set; }
}

/// <summary>
/// Tendencia diaria de sentimiento
/// </summary>
public class DailySentimentDto
{
    public DateTime Date { get; set; }
    public double HappyRate { get; set; }
    public double NeutralRate { get; set; }
    public double UnhappyRate { get; set; }
    public int TotalViewers { get; set; }
}