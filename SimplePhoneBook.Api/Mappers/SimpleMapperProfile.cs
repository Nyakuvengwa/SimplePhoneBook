using AutoMapper;
using SimplePhoneBook.Api.Models;
using SimplePhoneBook.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePhoneBook.Api.Mappers
{
    public class SimpleMapperProfile : Profile 
    {
        public SimpleMapperProfile()
        {
            CreateMap<PhoneNumberTypeModel, PhoneNumberType>().ReverseMap();
            CreateMap<ContactModel, Contact>().ReverseMap();
            CreateMap<PhoneNumberModel, PhoneNumber>().ReverseMap();
        }
    }
}
