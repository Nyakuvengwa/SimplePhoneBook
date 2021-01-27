using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SimplePhoneBook.Data.Data
{
    class SimplePhoneBookDbContextFactory : IDesignTimeDbContextFactory<SimplePhoneBookDbContext>
    {
        public SimplePhoneBookDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SimplePhoneBookDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=SimplePhoneBook;Trusted_Connection=True;");
            return new SimplePhoneBookDbContext(optionsBuilder.Options);
        }
    }
}
