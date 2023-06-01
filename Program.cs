using Microsoft.EntityFrameworkCore;
Console.WriteLine("Hello");
public class EquipmentDbContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Need> Needs { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-FD4Q2N8;Database=Ecommerce;Trusted_Connection=False;Integrated Security=True;TrustServerCertificate=True;");
    }
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Need
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
    }
}