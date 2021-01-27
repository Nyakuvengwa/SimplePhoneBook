using System.ComponentModel.DataAnnotations;

namespace SimplePhoneBook.Api.Models
{
    public class PhoneNumberTypeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
