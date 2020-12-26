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
