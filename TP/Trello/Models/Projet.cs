using System;
using System.Collections.Generic;

namespace scrap.Models;

public partial class Projet
{
	public int Id { get; set; }

	public string Nom { get; set; } = null!;

	public string? Description { get; set; }

	public DateTime DateCreation { get; set; }

	public virtual ICollection<Liste> Listes { get; } = new List<Liste>();

	public virtual ICollection<Utilisateur> IdUtilisateurs { get; } = new List<Utilisateur>();

	public Projet()
	{
	}

	public Projet(string nom, string? description, DateTime dateCreation = default)
	{
		Nom = nom;
		Description = description;
		DateCreation = dateCreation;
	}

	public Projet(string nom, string? description, ICollection<Utilisateur> utilisateurs, DateTime dateCreation = default)
	{
		Nom = nom;
		Description = description;
		DateCreation = dateCreation;
		IdUtilisateurs = utilisateurs;
		for (int i = 0; i < utilisateurs.Count; i++)
		{
			utilisateurs[i].IdProjet.Add(this);
		}
	}

	public void AddUtilisateur(Utilisateur utilisateur)
	{
		IdUtilisateurs.Add(utilisateur);
		utilisateur.IdProjet.Add(this);
	}

	public void AddListe(Liste liste)
	{
		Listes.Add(liste);
		liste.IdProjet = this;
	}

	public ICollection<Utilisateur> GetUtilisateurs()
	{
		return IdUtilisateurs;
	}

	public ICollection<Liste> GetListes()
	{
		return Listes;
	}

}
