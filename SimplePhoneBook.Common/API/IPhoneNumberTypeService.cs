using SimplePhoneBook.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhoneBook.Common.API
{
    public interface IPhoneNumberTypeService
    {
        public Task<List<PhoneNumberType>> GetAllPhoneNumberTypes();

        public Task<PhoneNumberType> GetPhoneNumberTypeById(int id);
    }
}
