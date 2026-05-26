using System.Net.Http.Json;
using AnalyticsDashboard.Models;

namespace AnalyticsDashboard.Services;

/// <summary>
/// Servicio para consumir la API REST
/// </summary>
public class ApiService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<ApiService> _logger;

    public ApiService(HttpClient httpClient, ILogger<ApiService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    /// <summary>
    /// Obtiene OTS agregados por día
    /// </summary>
    public async Task<List<OtsDailyDto>?> GetOtsDailyAsync(DateTime? startDate = null, DateTime? endDate = null)
    {
        try
        {
            var url = "api/Ots/daily";
            var queryParams = new List<string>();

            if (startDate.HasValue)
                queryParams.Add($"startDate={startDate.Value:yyyy-MM-dd}");
            if (endDate.HasValue)
                queryParams.Add($"endDate={endDate.Value:yyyy-MM-dd}");

            if (queryParams.Any())
                url += "?" + string.Join("&", queryParams);

            _logger.LogInformation($"Calling API: {url}");
            return await _httpClient.GetFromJsonAsync<List<OtsDailyDto>>(url);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting OTS daily data");
            return new List<OtsDailyDto>();
        }
    }

    /// <summary>
    /// Obtiene OTS agregados por hora
    /// </summary>
    public async Task<List<OtsHourlyDto>?> GetOtsHourlyAsync(DateTime? startDate = null, DateTime? endDate = null)
    {
        try
        {
            var url = "api/Ots/hourly";
            var queryParams = new List<string>();

            if (startDate.HasValue)
                queryParams.Add($"startDate={startDate.Value:yyyy-MM-dd}");
            if (endDate.HasValue)
                queryParams.Add($"endDate={endDate.Value:yyyy-MM-dd}");

            if (queryParams.Any())
                url += "?" + string.Join("&", queryParams);

            _logger.LogInformation($"Calling API: {url}");
            return await _httpClient.GetFromJsonAsync<List<OtsHourlyDto>>(url);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting OTS hourly data");
            return new List<OtsHourlyDto>();
        }
    }

    /// <summary>
    /// Obtiene comparativa OTS vs Watchers
    /// </summary>
    public async Task<List<ComparisonDto>?> GetComparisonAsync(DateTime? startDate = null, DateTime? endDate = null)
    {
        try
        {
            var url = "api/Analytics/comparison";
            var queryParams = new List<string>();

            if (startDate.HasValue)
                queryParams.Add($"startDate={startDate.Value:yyyy-MM-dd}");
            if (endDate.HasValue)
                queryParams.Add($"endDate={endDate.Value:yyyy-MM-dd}");

            if (queryParams.Any())
                url += "?" + string.Join("&", queryParams);

            _logger.LogInformation($"Calling API: {url}");
            return await _httpClient.GetFromJsonAsync<List<ComparisonDto>>(url);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting comparison data");
            return new List<ComparisonDto>();
        }
    }

    /// <summary>
    /// Obtiene distribución demográfica de viewers
    /// </summary>
    public async Task<List<ViewerDemographicDto>?> GetDemographicsAsync(DateTime? startDate = null, DateTime? endDate = null)
    {
        try
        {
            var url = "api/Viewers/demographics";
            var queryParams = new List<string>();

            if (startDate.HasValue)
                queryParams.Add($"startDate={startDate.Value:yyyy-MM-dd}");
            if (endDate.HasValue)
                queryParams.Add($"endDate={endDate.Value:yyyy-MM-dd}");

            if (queryParams.Any())
                url += "?" + string.Join("&", queryParams);

            _logger.LogInformation($"Calling API: {url}");
            return await _httpClient.GetFromJsonAsync<List<ViewerDemographicDto>>(url);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting demographics data");
            return new List<ViewerDemographicDto>();
        }
    }

    /// <summary>
    /// Obtiene análisis de sentimiento
    /// </summary>
    public async Task<SentimentDto?> GetSentimentAsync(DateTime? startDate = null, DateTime? endDate = null)
    {
        try
        {
            var url = "api/Analytics/sentiment";
            var queryParams = new List<string>();

            if (startDate.HasValue)
                queryParams.Add($"startDate={startDate.Value:yyyy-MM-dd}");
            if (endDate.HasValue)
                queryParams.Add($"endDate={endDate.Value:yyyy-MM-dd}");

            if (queryParams.Any())
                url += "?" + string.Join("&", queryParams);

            _logger.LogInformation($"Calling API: {url}");
            return await _httpClient.GetFromJsonAsync<SentimentDto>(url);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting sentiment data");
            return null;
        }
    }
}