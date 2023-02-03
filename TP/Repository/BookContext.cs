using Microsoft.EntityFrameworkCore;
namespace Library;



public class BookContext : DbContext
{

	public DbSet<Dog> Dogs { get; set; }// <- nom de la table = nom du DbSet
	public DbSet<Book> Books { get; set; }// <- nom de la table = nom du DbSet

	public BookContext()
	{
		Database.EnsureCreated();// <- assurer la creation de la base de donne Si elle n'existe pas
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// Quand ?
	{
		optionsBuilder.UseMySQL("Server=localhost;Database=Library;User=root;Password=0000");
	}
}
