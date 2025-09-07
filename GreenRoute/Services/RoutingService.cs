using GreenRoute.Models;

namespace GreenRoute.Services;

public class RouteData
{
    public double Distance { get; set; } // in meters
    public double Duration { get; set; } // in seconds
}

public class RoutingService
{
    private readonly HttpClient _httpClient;

    public RoutingService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<RouteData?> GetRouteDataAsync(Coordinate start, Coordinate end)
    {
        // Implementation will be added in Sprint 2
        throw new NotImplementedException();
    }
}