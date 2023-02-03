
using Animaux;

namespace Tp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Read Update Delete
			using (var db = new PokemonContext())
			{
				db.Pokemon.Add(new Salameche("Salameche"));
				db.Pokemon.Add(new Carapuce("Carapuce"));
				db.Pokemon.Add(new Bulbizar("Bulbizar"));
				db.SaveChanges();

				var pokemon = db.Pokemon.Find(1);
				Console.WriteLine(pokemon.Name);
				pokemon.Attack();

				pokemon = db.Pokemon.Find(2);
				Console.WriteLine(pokemon.Name);
				pokemon.Attack();

				pokemon = db.Pokemon.Find(3);
				Console.WriteLine(pokemon.Name);
				pokemon.Attack();
			}
		}
	}
}
