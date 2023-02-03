using Library;
using Microsoft.EntityFrameworkCore;


// Crud -> Create, Read, Update, Delete

// var repo = new Repository<Book>(context);// Instance de classe
// var repo2 = new Repository<Dog>(context);// Instance de classe


var context = new BookContext();
Book livre = new Book("titre", "Auteur", 15f); // Instance de classe Book
var repo = new Repository<Book>(context);

repo.add(livre);
