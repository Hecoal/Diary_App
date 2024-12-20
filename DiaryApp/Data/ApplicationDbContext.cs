using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<DiaryEntry>DiaryEntries{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                    new DiaryEntry { 
                        Id= 1, 
                        Title= "Went to the cinema", 
                        Content= "Went to the cinema to watch a movie.", 
                        Created=DateTime.Today
                    },
                    new DiaryEntry
                    {
                        Id = 2,
                        Title = "Went shopping",
                        Content = "Went shopping unicorn onesies.",
                        Created = DateTime.Today
                    },
                    new DiaryEntry
                    {
                        Id = 3,
                        Title = "Went diving",
                        Content = "Went diving after shopping!",
                        Created = DateTime.Today
                    }
                );
        }
    }
}
