using Microsoft.EntityFrameworkCore;
using SimplePhoneBook.Data.Entites;

namespace SimplePhoneBook.Data.Data
{
    public class SimplePhoneBookDbContext : DbContext
    {
        public SimplePhoneBookDbContext(DbContextOptions<SimplePhoneBookDbContext> options) : base(options)
        {
        }

        protected SimplePhoneBookDbContext()
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasKey(e => e.Id).IsClustered(false);
        }
    }
}
