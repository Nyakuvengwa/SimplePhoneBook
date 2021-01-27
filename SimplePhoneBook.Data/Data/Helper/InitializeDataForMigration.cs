using Microsoft.EntityFrameworkCore;
using SimplePhoneBook.Data.Entites;
using System;
using System.Collections.Generic;

namespace SimplePhoneBook.Data.Data.Helper
{
    public class InitializeDataForMigration
    {
        private readonly ModelBuilder _modelBuilder;
        public InitializeDataForMigration(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        public void InsertData()
        {
            InsertPhoneNumberTypes();
        }

        private void InsertPhoneNumberTypes()
        {
            int id = 1;
            var phonNumberTypesToInsert = new List<PhoneNumberType>()
            {
                new PhoneNumberType(){ Id = id++ , Name = "Mobile" , ModifiedDate = DateTime.Now},
                new PhoneNumberType(){ Id = id++ , Name = "Home" , ModifiedDate = DateTime.Now},
                new PhoneNumberType(){ Id = id++ , Name = "Work" , ModifiedDate = DateTime.Now},
                new PhoneNumberType(){ Id = id++ , Name = "Other" , ModifiedDate = DateTime.Now}
            };
            _modelBuilder.Entity<PhoneNumberType>().HasData(phonNumberTypesToInsert);
        }
    }
}
