using System;
using System.Collections.Generic;

namespace scrap.Models;

public partial class Carte
{
	public int Id { get; set; }

	public string Titre { get; set; } = null!;

	public string? Description { get; set; }

	public DateTime DateCreation { get; set; }

	public int IdListe { get; set; }

	public virtual ICollection<Commentaire> Commentaires { get; } = new List<Commentaire>();

	public virtual ICollection<Etiquette> Etiquettes { get; } = new List<Etiquette>();

	public virtual Liste IdListeNavigation { get; set; } = null!;

	public Carte()
	{
	}

	public Carte(string titre, string? description, DateTime dateCreation, Liste newListe)
	{
		Titre = titre;
		Description = description;
		DateCreation = dateCreation;
		IdListeNavigation = newListe;
		IdListe = newListe.Id;
	}

	public changePosition(int newPosition)
	{
		IdListeNavigation.Cartes.Remove(this);
		IdListeNavigation.Cartes.Insert(newPosition, this);
	}

	public addCommentaire(Commentaire newCommentaire)
	{
		Commentaires.Add(newCommentaire);
	}

	public removeCommentaire(Commentaire oldCommentaire)
	{
		Commentaires.Remove(oldCommentaire);
	}

	public addEtiquette(Etiquette newEtiquette)
	{
		Etiquettes.Add(newEtiquette);
	}

	public removeEtiquette(Etiquette oldEtiquette)
	{
		Etiquettes.Remove(oldEtiquette);
	}

	public changeListe(Liste newListe)
	{
		IdListeNavigation.Cartes.Remove(this);
		IdListeNavigation = newListe;
		IdListe = newListe.Id;
		IdListeNavigation.Cartes.Add(this);
	}

	public changeTitre(string newTitre)
	{
		Titre = newTitre;
	}

	public changeDescription(string newDescription)
	{
		Description = newDescription;
	}

	public ICollection<Commentaire> GetCommentaires()
	{
		return Commentaires;
	}

	public ICollection<Etiquette> GetEtiquettes()
	{
		return Etiquettes;
	}
}
