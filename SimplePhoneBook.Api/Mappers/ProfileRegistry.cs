using System;

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
