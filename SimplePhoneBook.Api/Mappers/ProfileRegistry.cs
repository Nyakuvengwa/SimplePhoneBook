using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePhoneBook.Api.Mappers
{
    public class ProfileRegistry
    {
        public ProfileRegistry()
        {
            RegisteredProfiles = new[] { typeof(SimpleMapperProfile) };
        }

        public Type[] RegisteredProfiles { get; }
    }
}
