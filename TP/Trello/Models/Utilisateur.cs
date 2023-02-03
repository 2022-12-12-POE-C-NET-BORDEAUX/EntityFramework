using System;
using System.Collections.Generic;

namespace scrap.Models;

public partial class Utilisateur
{
	public int Id { get; set; }

	public string Nom { get; set; } = null!;

	public string Email { get; set; } = null!;

	public string MotDePasse { get; set; } = null!;

	public DateTime DateInscription { get; set; }

	public virtual ICollection<Commentaire> Commentaires { get; } = new List<Commentaire>();

	public virtual ICollection<Projet> IdProjet { get; } = new List<Projet>();

	public Utilisateur()
	{
	}

	public Utilisateur(string nom, string email, string motDePasse, DateTime dateInscription = default)
	{
		Nom = nom;
		Email = email;
		MotDePasse = motDePasse;
		DateInscription = dateInscription;
	}

	public Utilisateur(string nom, string email, string motDePasse, ICollection<Projet> projets, DateTime dateInscription = default)
	{
		Nom = nom;
		Email = email;
		MotDePasse = motDePasse;
		DateInscription = dateInscription;
		IdProjet = projets;
		for (int i = 0; i < projets.Count; i++)
		{
			projets[i].IdUtilisateurs.Add(this);
		}
	}

	public void AddProjet(Projet projet)
	{
		IdProjet.Add(projet);
		projet.IdUtilisateurs.Add(this);
	}

	public ICollection<Projet> GetProjets()
	{
		return IdProjet;
	}

	public ICollection<Commentaire> GetCommentaires()
	{
		return Commentaires;
	}
}
