using App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Race> Races { get; set; }
    public DbSet<RaceResult> RaceResults { get; set; }
    public DbSet<ResultItem> ResultItem { get; set; }
    public DbSet<VehiculeCat> VehiculeCats {get;set;}
    public DbSet<Vehicule> Vehicules {get;set;}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}