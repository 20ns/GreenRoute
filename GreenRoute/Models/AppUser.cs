using Microsoft.AspNetCore.Identity;

namespace GreenRoute.Models;

public class AppUser : IdentityUser
{
    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}