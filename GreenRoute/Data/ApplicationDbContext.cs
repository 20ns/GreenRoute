using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GreenRoute.Models;

namespace GreenRoute.Data;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Configure Vehicle-User relationship
        builder.Entity<Vehicle>()
            .HasOne(v => v.User)
            .WithMany(u => u.Vehicles)
            .HasForeignKey(v => v.UserId);
    }
}