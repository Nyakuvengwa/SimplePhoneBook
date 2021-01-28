using SimplePhoneBook.Common.API;
using SimplePhoneBook.Data.Entites;
using SimplePhoneBook.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplePhoneBook.Common.Service
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task DeleteContactByIdAsync(int contactId)
        {
            var contact = await _contactRepository.GetContactByIdAsync(contactId);
            if (contact == null)
            {
                throw new System.Exception($"{nameof(DeleteContactByIdAsync)} Entity Not found - {contactId}");
            }
            await  _contactRepository.DeleteAsync(contact);
        }

        public async Task<List<Contact>> FindContactsByQueryString(string searchTerm)
        {
            return await _contactRepository.FindContactsByQueryString(searchTerm);
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            return await _contactRepository.GetAllContacts();
        }

        public async Task<Contact> GetContactByIdAsync(int contactId)
        {
            return await _contactRepository.GetContactByIdAsync(contactId);
        }

        public async Task<Contact> UpdateContact(Contact contact)
        {
            return await _contactRepository.UpdateAsync(contact);
        }
    }
}
