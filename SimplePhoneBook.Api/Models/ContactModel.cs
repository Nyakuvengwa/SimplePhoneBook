using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePhoneBook.Api.Models
{
    public class ContactModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public List<PhoneNumberModel> PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string Base64EncodedImage { get; set; }
    }
}
