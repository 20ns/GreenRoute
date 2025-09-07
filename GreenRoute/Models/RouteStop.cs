namespace GreenRoute.Models;

public class RouteStop
{
    public string Address { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public int Order { get; set; }
}