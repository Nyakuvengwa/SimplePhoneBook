using Microsoft.EntityFrameworkCore;
using SimplePhoneBook.Data.Data;
using SimplePhoneBook.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhoneBook.Data.Repositories
{
   public class PhoneNumberTypeRepository : Repository<PhoneNumberType>, IPhoneNumberTypeRepository
    {
        public PhoneNumberTypeRepository(SimplePhoneBookDbContext dbContext): base(dbContext) 
        {
        }

        public async Task<List<PhoneNumberType>> GetAllPhoneNumberTypes()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<PhoneNumberType> GetPhoneNumberTypeById(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
