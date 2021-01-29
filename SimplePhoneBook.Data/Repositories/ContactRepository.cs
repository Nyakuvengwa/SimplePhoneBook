using Microsoft.EntityFrameworkCore;
using SimplePhoneBook.Data.Data;
using SimplePhoneBook.Data.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePhoneBook.Data.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(SimplePhoneBookDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Contact>> FindContactsByQueryString(string searchTerm)
        {

            return await GetAll().Where(c => 
            c.FirstName.ToLower().Contains(searchTerm.ToLower()) ||
            c.LastName.ToLower().Contains(searchTerm.ToLower()) ||
            c.PhoneNumber.ToLower().Contains(searchTerm.ToLower()) ||
            c.EmailAddress.ToLower().Contains(searchTerm.ToLower())
            ).ToListAsync();
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Contact> GetContactByIdAsync(int contactId)
        {
            return await GetAll().FirstOrDefaultAsync(c => c.Id == contactId);
        }       
    }
}
