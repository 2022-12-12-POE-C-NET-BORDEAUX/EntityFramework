
using Animaux;

namespace Tp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Read Update Delete
			using (var db = new AnimauxContext())
			{
				// Create
				var chat = new Cat { Name = "Felix", Age = 3 };
				db.Animaux.Add(chat);
				db.SaveChanges();

				var agneaux = new Agneaux { Name = "Agneaux", Age = 3 };
				db.Animaux.Add(agneaux);
				db.SaveChanges();


				// Read
				var animaux = db.Animaux;
				foreach (var animal in animaux)
				{
					Console.WriteLine(animal.Name);
				}

				// Update
				chat.Age = 4;
				db.SaveChanges();

				// Delete
				db.Animaux.Remove(chat);
				db.SaveChanges();
			}
		}
	}
}
