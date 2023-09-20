using FreakyFashion.Domain;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion.Data;//Återspeglar vart filen ligger

public class ApplicationDbContext : DbContext//Möjligör kommikationen med databasen
{

    private string connectionString = "Server=.;Database=FreakyFashion;Integrated Security=False;Encrypt=False;User ID=SA;Password=Dinoaugust123456!;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }
    //Kunna prata med tabellen som skapades
    public DbSet<Product> Product { get; set; }

}
