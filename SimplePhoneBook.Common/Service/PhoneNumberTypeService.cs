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
        private readonly IPhoneNumberTypeRepository _repository;

        public PhoneNumberTypeService(IPhoneNumberTypeRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PhoneNumberType>> GetAllPhoneNumberTypes()
        {
            return await _repository.GetAllPhoneNumberTypes();
        }

        public async Task<PhoneNumberType> GetPhoneNumberTypeById(int id)
        {
            return await _repository.GetPhoneNumberTypeById(id);
        }
    }
}
