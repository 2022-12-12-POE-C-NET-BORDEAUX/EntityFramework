using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext
{
	public DbSet<Department> Departments { get; set; }
	public DbSet<Employee> Employees { get; set; }

	public MyContext()
	{
		Database.EnsureDeleted();
		Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySQL("server=localhost;database=jointureOtM;user=root;password=0000");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Employee>()
			.HasOne(e => e.Department)
			.WithMany(d => d.Employees)
			.HasForeignKey(e => e.DepartmentId);
	}
}
