using Microsoft.EntityFrameworkCore;

class Program
{
	static void Main(string[] args)
	{
		using (var context = new MyContext())
		{
			// Create a new person and passport
			var person = new Person { Name = "John Doe" };
			var passport = new Passport { PassportNumber = "12345678" };
			person.Passport = passport;
			context.People.Add(person);
			context.SaveChanges();

			// Read the person and passport information
			var john = context.People.Include(p => p.Passport).SingleOrDefault(p => p.Name == "John Doe");
			Console.WriteLine($"{john.Name}'s passport number is {john.Passport.PassportNumber}");

			// Update the passport number
			john.Passport.PassportNumber = "87654321";
			context.SaveChanges();

			// Delete the person and passport
			context.People.Remove(john);
			context.SaveChanges();
		}
	}
}
