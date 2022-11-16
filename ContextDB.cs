using Microsoft.EntityFrameworkCore;

public class ContextDB: Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<TestDrive>? TestDrives { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=customers.db;");
    }
}