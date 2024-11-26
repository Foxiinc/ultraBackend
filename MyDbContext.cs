using Microsoft.EntityFrameworkCore;


public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<MyEntity>? MyEntities { get; set; }
}

public class MyEntity
{
    public int Id { get; set; }
    public int UserId {get; set;}
    public int idServer {get; set;}
    public string? Name { get; set; }
    public int CountCubes {get; set;}
    public int CountBytes {get; set;}
    public int CountRefs {get; set;}
    public int CountBoosts {get; set;}
}