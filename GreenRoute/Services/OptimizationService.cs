using GreenRoute.Models;

namespace GreenRoute.Services;

public class OptimizedRoute
{
    public List<RouteStop> OrderedStops { get; set; } = new List<RouteStop>();
    public double TotalDistance { get; set; }
    public double TotalDuration { get; set; }
    public double CarbonFootprint { get; set; }
}

public class OptimizationService
{
    private readonly RoutingService _routingService;

    public OptimizationService(RoutingService routingService)
    {
        _routingService = routingService;
    }

    public async Task<OptimizedRoute> OptimizeRouteAsync(List<Coordinate> stops, Coordinate start, Vehicle vehicle)
    {
        // Implementation will be added in Sprint 3
        throw new NotImplementedException();
    }

    private double CalculateCarbonFootprint(double totalDistance, Vehicle vehicle)
    {
        // Implementation will be added in Sprint 3
        throw new NotImplementedException();
    }
}