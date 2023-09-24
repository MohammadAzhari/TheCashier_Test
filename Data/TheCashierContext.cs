using Microsoft.EntityFrameworkCore;
using TheCashier.Config;
using TheCashier.Models;

namespace TheCashier;
public class TheCashierContext : DbContext
{
    private readonly string connectionString;

    public TheCashierContext(DB db)
    {
        connectionString = db.ConnectionString;
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}
