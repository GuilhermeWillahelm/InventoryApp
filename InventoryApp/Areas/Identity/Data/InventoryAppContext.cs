using InventoryApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Security.Claims;

namespace InventoryApp.Areas.Identity.Data;

public class InventoryAppContext : IdentityDbContext<InventoryAppUser>
{
    public InventoryAppContext(DbContextOptions<InventoryAppContext> options)
        : base(options)
    {
    }

    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        builder.Entity<Inventory>().Property(u => u.Price).HasPrecision(12, 10);
    }
}


public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<InventoryAppUser>
{
    public void Configure(EntityTypeBuilder<InventoryAppUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}
