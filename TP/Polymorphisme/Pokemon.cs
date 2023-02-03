namespace Animaux
{
	public abstract class Pokemon
	{
		public int Id { get; set; }
		public string Name { get; set; }
		protected string Type;

		public abstract void Attack();
	}

	public class Salameche : Pokemon
	{
		public Salameche()
		{
			this.Type = new string("Fire");
			this.Name = new string("");
		}

		public Salameche(string Name)
		{
			this.Type = new string("Fire");
			this.Name = new string(Name);
		}

		public override void Attack()
		{
			Console.WriteLine("Flammeche");
		}
	}

	public class Carapuce : Pokemon
	{
		public Carapuce()
		{
			this.Type = new string("Water");
			this.Name = new string("");
		}

		public Carapuce(string Name)
		{
			this.Type = new string("Water");
			this.Name = new string(Name);
		}

		public override void Attack()
		{
			Console.WriteLine("Hydrocanon");
		}
	}

	public class Bulbizar : Pokemon
	{
		public Bulbizar()
		{
			this.Type = new string("Grass");
			this.Name = new string("");
		}

		public Bulbizar(string Name)
		{
			this.Type = new string("Grass");
			this.Name = new string(Name);
		}

		public override void Attack()
		{
			Console.WriteLine("Lance-soleil");
		}
	}
}
