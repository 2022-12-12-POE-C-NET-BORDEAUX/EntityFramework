using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext
{
	public DbSet<Person> People { get; set; }
	public DbSet<Passport> Passports { get; set; }

	public MyContext()
	{
		Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySQL("server=localhost;database=jointure;user=root;password=0000");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Person>()
			.HasOne(p => p.Passport)
			.WithOne(p => p.Person)
			.HasForeignKey<Passport>(p => p.PersonId);
	}
}
