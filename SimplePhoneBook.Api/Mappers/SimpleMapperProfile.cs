using AutoMapper;
using SimplePhoneBook.Api.Models;
using SimplePhoneBook.Data.Entites;

namespace SimplePhoneBook.Api.Mappers
{
    public class SimpleMapperProfile : Profile 
    {
        public SimpleMapperProfile()
        {
            CreateMap<ContactModel, Contact>().ReverseMap();
        }
    }
}
