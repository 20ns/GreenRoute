using System.ComponentModel.DataAnnotations;

namespace GreenRoute.Models;

public class Vehicle
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    public string VehicleType { get; set; } = string.Empty; // "Gas", "Diesel", "Electric"
    
    [Required]
    public double FuelEfficiency { get; set; } // km/L or km/kWh
    
    [Required]
    public string UserId { get; set; } = string.Empty;
    
    public virtual AppUser User { get; set; } = null!;
}