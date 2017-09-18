using System.Data.Entity;
namespace AutoCreate
{
    public class ToolsDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("IDSERV");
        }

    }
}
