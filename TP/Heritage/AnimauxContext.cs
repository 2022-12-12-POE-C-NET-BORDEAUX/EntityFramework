using Microsoft.EntityFrameworkCore;

namespace Animaux
{
	public class AnimauxContext : DbContext
	{
		public DbSet<Animal>? Animaux { get; set; }

		public AnimauxContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL("Server=localhost;Database=Animaux;User=root;Password=0000");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Animal>()
				.HasDiscriminator<string>("Type")
				.HasValue<Cat>("Chat")
				.HasValue<Agneaux>("Agneaux");
		}
	}
}
