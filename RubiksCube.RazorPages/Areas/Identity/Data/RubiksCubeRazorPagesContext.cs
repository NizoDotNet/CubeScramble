using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RubiksCube.RazorPages.Areas.Identity.Data;
using RubiksCube.RazorPages.Model;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace RubiksCube.RazorPages.Data;

public class RubiksCubeRazorPagesContext : IdentityDbContext<SpeedCuber>
{
    public RubiksCubeRazorPagesContext(DbContextOptions<RubiksCubeRazorPagesContext> options)
        : base(options)
    {
    }
    public DbSet<ScrambleModel> Scrambles { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<SpeedCuber>()
        .HasMany(e => e.Scrambles)
        .WithOne(e => e.SpeedCuber)
        .HasForeignKey(e => e.SpeedCuberId)
        .IsRequired(false);

    }
}
