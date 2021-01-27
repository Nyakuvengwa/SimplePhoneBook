using SimplePhoneBook.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhoneBook.Data.Repositories
{
    public interface IPhoneNumberTypeRepository : IRepository<PhoneNumberType>
    {
        public Task<List<PhoneNumberType>> GetAllPhoneNumberTypes();

        public Task<PhoneNumberType> GetPhoneNumberTypeById(int id);
    }
}
