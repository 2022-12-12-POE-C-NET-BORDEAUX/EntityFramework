using System;
using Microsoft.EntityFrameworkCore;
using System.Threading;


public class Program
{
    public static void Main(string[] args)
    {
        using (var db = new PizzaContext())
        {
            // Add a new pizza to the database
            var pizza = new Pizza { Name = "Margherita", Price = 8.99M, Description = "A classic tomato and mozzarella pizza" };
            db.Pizzas.Add(pizza);
			// Thread.Sleep(10000);
            db.SaveChanges();

            // Display all pizzas in the database
            Console.WriteLine("All pizzas in the database:");

			Console.WriteLine(db.Pizzas.Find(1).Name);

            // foreach (var p in db.Pizzas)
            // {
            //     Console.WriteLine(p.Name);
            // }
        }
    }
}
