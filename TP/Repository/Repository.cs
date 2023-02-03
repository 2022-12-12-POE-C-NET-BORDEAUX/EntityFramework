using System;
using Microsoft.EntityFrameworkCore;
namespace Library;

public class Repository<T> where T : class // specification de la classe
{
	// T est donc inconnu
	private BookContext _db;
	private DbSet<T> _table;
	// private ?? table

	public Repository(BookContext db)
	{
		_db = db;
		_table = db.Set<T>();
		Console.WriteLine("Le repo est creer");
	}

	public void add(T entity)
	{
		using (var transaction = _db.Database.BeginTransaction())
		{
			try
			{
				_table.Add(entity); // <- double id entite
				_db.SaveChanges();
				transaction.Commit();
			}
			catch (Exception)
			{
				transaction.Rollback();
			}
		}
	}

	public void Update()
	{
		_db.SaveChanges();
	}
	//CRUD
}

