using SimplePhoneBook.Data.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplePhoneBook.Common.API
{
    public interface IContactService
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task DeleteContactByIdAsync(int contactId);

        Task<List<Contact>> FindContactsByQueryStringAsync(string searchTerm);

        Task<List<Contact>> GetAllContactsAsync();

        Task<Contact> GetContactByIdAsync(int contactId);

        Task<Contact> UpdateContactAsync(Contact contact);
    }
}