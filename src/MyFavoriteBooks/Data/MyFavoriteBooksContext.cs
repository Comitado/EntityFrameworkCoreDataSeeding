using Microsoft.EntityFrameworkCore;
using MyFavoriteBooks.Models;
using System;

namespace MyFavoriteBooks.Data
{
    public class MyFavoriteBooksContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed data model approach
            modelBuilder.Entity<Author>()
                .HasData(new Author { Id = 1, FirstName = "Robert C.", LastName = "Martin" });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                optionsBuilder.UseSqlite($"Data Source={userPath}/EntityFrameworkCoreDataSeeding.db;");
            }
        }
    }
}
