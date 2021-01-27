using Microsoft.EntityFrameworkCore;
using SimplePhoneBook.Data.Data.Helper;
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
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasKey(e => e.Id).IsClustered(false);

            modelBuilder.Entity<PhoneNumber>().HasKey(e => e.Id).IsClustered(false);
            modelBuilder.Entity<PhoneNumber>().HasIndex(e => e.PhoneNumberTypeId).IsClustered(false).IsUnique();

            modelBuilder.Entity<PhoneNumberType>().HasKey(e => e.Id).IsClustered(false);

            new InitializeDataForMigration(modelBuilder).InsertData();
        }
    }
}
