// Needed for accessing database

using Microsoft.EntityFrameworkCore;


namespace HairSalon.Models 
{
  public class HairSalonContext : DbContext 
  {
    public DbSet<ClassName> ClassNames { get; set; }  // CHANGE CLASS NAME!!!

    public HairSalonContext(DbContextOptions options) : base(options) { } 
  }
}