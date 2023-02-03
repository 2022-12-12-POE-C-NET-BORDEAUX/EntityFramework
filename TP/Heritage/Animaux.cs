namespace Animaux
{
	public abstract class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int Age { get; set; }
		public string Type { get; set; }

		public abstract void Cri();
	}

	public class Cat : Animal
	{
		public Cat()
		{
			this.Name = new string("");
			this.Type = new string("Chat");
		}

		public Cat(string Name)
		{
			this.Name = new string(Name);
			this.Type = new string("Chat");
		}

		public override void Cri()
		{
			Console.WriteLine("C'est moi le chat");
		}
	}

	public class Agneaux : Animal
	{
		public Agneaux()
		{
			this.Name = new string("");
			this.Type = new string("Agneaux");
		}

		public Agneaux(string Name)
		{
			this.Name = new string(Name);
			this.Type = new string("Agneaux");
		}

		public override void Cri()
		{
			Console.WriteLine("aucun son");
		}
	}
}
