namespace GreenRoute.Models;

public class RouteRequest
{
    public string StartAddress { get; set; } = string.Empty;
    public List<string> StopAddresses { get; set; } = new List<string>();
    public int VehicleId { get; set; }
}