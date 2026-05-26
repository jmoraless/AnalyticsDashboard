using System;

namespace AnalyticsDashboard.Services;

public class DashboardState
{
    public event Action? OnDataLoaded;

    private bool _isDataLoaded = false;
    public bool IsDataLoaded
    {
        get => _isDataLoaded;
        set
        {
            if (_isDataLoaded != value)
            {
                _isDataLoaded = value;
                if (value)
                {
                    Console.WriteLine("🎯 DashboardState: Notificando que los datos están listos");
                    OnDataLoaded?.Invoke();
                }
            }
        }
    }

    public void NotifyDataLoaded()
    {
        IsDataLoaded = true;
    }
}