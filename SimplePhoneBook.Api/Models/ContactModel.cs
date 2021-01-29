using System.ComponentModel.DataAnnotations;

namespace SimplePhoneBook.Api.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
