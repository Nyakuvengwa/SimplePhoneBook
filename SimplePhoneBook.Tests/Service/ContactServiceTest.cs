using SimplePhoneBook.Common.Service;
using SimplePhoneBook.Tests.Mocks;
using System.Threading.Tasks;
using Xunit;

namespace SimplePhoneBook.Tests.Service
{
    public class ContactServiceTest
    {
        [Fact]
        public async Task AddContactAsyncReturnsContactWhenValidContactIsPassedAsync()
        {
           var contactRepository = TestHelper.GetMockContactRepository();
           var service = new ContactService(contactRepository);
           var contact = TestHelper.GetContactMockEnity();
           var result =  await service.AddContactAsync(contact);

           Assert.NotNull(result);
        }
        [Fact]
        public async Task AddContactAsyncThrowsExceptionWhenNullContactIsPassed()
        {
            var contactRepository = TestHelper.GetMockContactRepository();
            var service = new ContactService(contactRepository);

            await Assert.ThrowsAsync< System.Exception>(() => service.AddContactAsync(null));
        }

        [Fact]
        public async Task UpdateContactAsyncReturnsContactWhenValidContactIsPassedAsync()
        {
            var contactRepository = TestHelper.GetMockContactRepository();
            var service = new ContactService(contactRepository);
            var contact = TestHelper.GetContactMockEnity();
            var result = await service.UpdateContactAsync(contact);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAllContactsAsyncReturnsContactsAsync()
        {
            var contactRepository = TestHelper.GetMockContactRepository();
            var service = new ContactService(contactRepository);
            var result = await service.GetAllContactsAsync();

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }
        
        [Fact]
        public async Task GetContactByIdAsyncReturnsContactsAsync()
        {
            var contactRepository = TestHelper.GetMockContactRepository();
            var service = new ContactService(contactRepository);
            var result = await service.GetContactByIdAsync(1);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeleteContactByIdAsyncReturnsContactsAsync()
        {
            var contactRepository = TestHelper.GetMockContactRepository();
            var service = new ContactService(contactRepository);
            await service.DeleteContactByIdAsync(1);
            Assert.True(true);
        }

        [Fact]
        public async Task FindContactsByQueryStringReturnsContactsAsync()
        {
            var contactRepository = TestHelper.GetMockContactRepository();
            var service = new ContactService(contactRepository);
            var result = await service.FindContactsByQueryStringAsync("name");

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }
    }
}
