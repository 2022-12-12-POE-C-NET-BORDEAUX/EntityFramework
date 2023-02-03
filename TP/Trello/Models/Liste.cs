using System;
using System.Collections.Generic;

namespace scrap.Models;

public partial class Liste
{
	public int Id { get; set; }

	public string Nom { get; set; } = null!;

	public int IdProjet { get; set; }

	public virtual ICollection<Carte> Cartes { get; } = new List<Carte>();

	public virtual Projet IdProjetNavigation { get; set; } = new Projet();

	public Liste()
	{
	}

	public Liste(string nom, Projet ProjetNavigation)
	{
		Nom = nom;
		IdProjetNavigation = ProjetNavigation;
		IdProjet = ProjetNavigation.Id;
	}

	public void AddCarte(Carte carte)
	{
		Cartes.Add(carte);
		carte.IdListeNavigation = this;
		carte.IdListe = Id;
	}

	public void RemoveCarte(Carte carte)
	{
		Cartes.Remove(carte);
		carte.IdListeNavigation = null;
		carte.IdListe = null;
	}

	public void SetProjet(Projet projet)
	{
		IdProjetNavigation = projet;
		IdProjet = projet.Id;
	}

	public void RemoveProjet()
	{
		IdProjetNavigation = null;
		IdProjet = null;
	}

	public ICollection<Carte> GetCartes()
	{
		return Cartes;
	}

	public ICollection<Carte> SortByName()
	{
		List<Carte> cartes = new List<Carte>(Cartes);
		cartes.Sort((x, y) => x.Nom.CompareTo(y.Nom));
		return cartes;
	}

	public ICollection<Carte> SortByDate()
	{
		List<Carte> cartes = new List<Carte>(Cartes);
		cartes.Sort((x, y) => x.Date.CompareTo(y.Date));
		return cartes;
	}
}
