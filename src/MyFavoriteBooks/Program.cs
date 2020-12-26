using MyFavoriteBooks.Data;
using MyFavoriteBooks.Models;
using System;
using System.Linq;

SeedingData();
PrintAuthors();

static void PrintAuthors()
{
    using var context = new MyFavoriteBooksContext();
    Console.WriteLine("Populated Authors: ");
    foreach (var author in context.Authors)
    {
        Console.WriteLine($"{author.FirstName} {author.LastName}");
    }
}

//Logic to populate database approach
static void SeedingData()
{
    using var context = new MyFavoriteBooksContext();
    context.Database.EnsureCreated();

    var author = context.Authors.FirstOrDefault(e => e.FirstName == "Robert C.");
    if (author is null)
    {
        context.Authors.Add(new Author() { FirstName = "Robert C.", LastName = "Martin" });
    }

    context.SaveChanges();
}