using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Setting Primary Keys
        modelBuilder.Entity<Faction>()
            .HasKey(f => f.factionId)
            .HasName("PK_Faction");
        
        //Required Properties
        modelBuilder.Entity<Faction>()
            .Property(f => f.factionId)
            .IsRequired()
            .IsUnicode();

        modelBuilder.Entity<Faction>()
            .Property(f => f.factionName)
            .IsRequired()
            .IsUnicode();
    }
    
    public DbSet<Faction> FactionsTable { get; set; }
}