using SimplePhoneBook.Data.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplePhoneBook.Common.API
{
    public interface IContactService
    {
        Task DeleteContactByIdAsync(int contactId);

        Task<List<Contact>> FindContactsByQueryString(string searchTerm);

        Task<List<Contact>> GetAllContacts();

        Task<Contact> GetContactByIdAsync(int contactId);

        Task<Contact> UpdateContact(Contact contact);
    }
}