using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext
{
	public DbSet<Student> Students { get; set; }
	public DbSet<Course> Courses { get; set; }

	public MyContext()
	{
		Database.EnsureDeleted();
		Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySQL("server=localhost;database=jointureMtM;user=root;password=0000");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<StudentCourse>()
				   .HasKey(sc => new { sc.StudentId, sc.CourseId });

		modelBuilder.Entity<StudentCourse>()
			.HasOne(sc => sc.Student)
			.WithMany(s => s.StudentCourses)
			.HasForeignKey(sc => sc.StudentId);

		modelBuilder.Entity<StudentCourse>()
			.HasOne(sc => sc.Course)
			.WithMany(c => c.StudentCourses)
			.HasForeignKey(sc => sc.CourseId);
	}
}
