using GreenRoute.Models;

namespace GreenRoute.Services;

public class GeocodingService
{
    private readonly HttpClient _httpClient;

    public GeocodingService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "GreenRoute-API/1.0 (https://github.com/20ns/GreenRoute)");
    }

    public async Task<Coordinate?> GetCoordinatesAsync(string address)
    {
        // Implementation will be added in Sprint 2
        throw new NotImplementedException();
    }
}