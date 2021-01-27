using SimplePhoneBook.Data.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplePhoneBook.Data.Repositories
{
    public interface IContactRepository : IRepository<Contact>
    {
        Task<List<Contact>> GetAllContacts();
        Task<Contact> GetContactByIdAsync(int contactId);
        Task<List<Contact>> FindContactsByQueryString(string searchTerm);
    }
}
