using Microsoft.EntityFrameworkCore;

public class PizzaContext : DbContext
{
	// annule le warning "The property 'PizzaContext.Pizzas' is never used"
	public DbSet<Pizza> Pizzas { get; set; }

	public PizzaContext()
	{
		// Database.EnsureDeleted();
		Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySQL("Server=localhost;Database=pizzadb;User=testuser;Password=password");
	}
}
