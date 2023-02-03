using Microsoft.EntityFrameworkCore;

namespace Animaux
{
	public class PokemonContext : DbContext
	{
		public DbSet<Pokemon>? Pokemon { get; set; }

		public PokemonContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL("Server=localhost;Database=pokemon;User=root;Password=0000");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Pokemon>()
				.HasDiscriminator<string>("Type")
				.HasValue<Salameche>("Fire")
				.HasValue<Carapuce>("Water")
				.HasValue<Bulbizar>("Grass");
		}
	}
}
