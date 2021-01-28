using SimplePhoneBook.Common.API;
using SimplePhoneBook.Data.Entites;
using SimplePhoneBook.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhoneBook.Common.Service
{
    public class PhoneNumberTypeService : IPhoneNumberTypeService
    {
        private readonly IPhoneNumberTypeRepository _phoneNumberTypeRepository;

        public PhoneNumberTypeService(IPhoneNumberTypeRepository repository)
        {
            _phoneNumberTypeRepository = repository;
        }
        public async Task<List<PhoneNumberType>> GetAllPhoneNumberTypes()
        {
            return await _phoneNumberTypeRepository.GetAllPhoneNumberTypes();
        }

        public async Task<PhoneNumberType> GetPhoneNumberTypeById(int id)
        {
            return await _phoneNumberTypeRepository.GetPhoneNumberTypeById(id);
        }
    }
}
