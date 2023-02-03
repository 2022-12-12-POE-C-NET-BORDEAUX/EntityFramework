using Microsoft.EntityFrameworkCore;

class Program
{
	static void Main(string[] args)
	{
		using (var context = new MyContext())
		{
			// Create
			var course = new Course { Name = "Math" };
			context.Courses.Add(course);
			context.SaveChanges();

			// Read
			var courses = context.Courses.ToList();
			foreach (var c in courses)
			{
				Console.WriteLine(c.Name);
			}

			// Update
			course = context.Courses.FirstOrDefault(c => c.Name == "Math");
			course.Name = "Mathematics";
			context.SaveChanges();

			// Delete
			context.Courses.Remove(course);
			context.SaveChanges();
		}
	}
}
