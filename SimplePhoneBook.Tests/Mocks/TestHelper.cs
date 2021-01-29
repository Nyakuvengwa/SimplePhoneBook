using Moq;
using SimplePhoneBook.Common.API;
using SimplePhoneBook.Data.Entites;
using SimplePhoneBook.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhoneBook.Tests.Mocks
{
    public static class TestHelper
    {
        public static IContactRepository GetMockContactRepository()
        {
            var  mockRepository = new Mock<IContactRepository>();
            mockRepository.Setup(x => x.AddAsync(It.IsAny<Contact>())).Returns(Task.FromResult(GetContactMockEnity()));
            mockRepository.Setup(x => x.UpdateAsync(It.IsAny<Contact>())).Returns(Task.FromResult(GetContactMockEnity()));
            mockRepository.Setup(x => x.GetAllContacts()).Returns(Task.FromResult(new List<Contact> { GetContactMockEnity() }));
            mockRepository.Setup(x => x.GetAllContacts()).Returns(Task.FromResult(new List<Contact> { GetContactMockEnity() }));
            mockRepository.Setup(x => x.GetContactByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(GetContactMockEnity()));
            mockRepository.Setup(x => x.DeleteAsync(It.IsAny<Contact>())).Returns(Task.FromResult(GetContactMockEnity()));
            mockRepository.Setup(x => x.FindContactsByQueryString(It.IsAny<string>())).Returns(Task.FromResult(new List<Contact> { GetContactMockEnity() }));


            return mockRepository.Object;
        }

        public static Contact GetContactMockEnity()
        {
            return new Contact() {
                FirstName = "Thabo",
                LastName = "Xia",
                EmailAddress = "a@b.com",
                PhoneNumber = "12345"
            };
        }

        public static IContactService GetMockContactService()
        {
            var mockService = new Mock<IContactService>();
            return mockService.Object;
        }

    }
}
