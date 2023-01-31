using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure;

public class DatabaseContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Setting Primary Keys
        modelBuilder.Entity<Faction>()
            .HasKey(f => f.factionId)
            .HasName("PK_Faction");
        
        //Required Properties
        modelBuilder.Entity<Faction>()
            .Property(f => f.factionId)
            .IsRequired();

        modelBuilder.Entity<Faction>()
            .Property(f => f.factionName)
            .IsRequired();
    }
    
    public DbSet<Faction> FactionsTable { get; set; }
}