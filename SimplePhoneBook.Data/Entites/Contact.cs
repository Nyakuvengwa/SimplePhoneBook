using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplePhoneBook.Data.Entites
{
   [Table(nameof(Contact))]
   public class Contact : Entity
    {
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        public List<PhoneNumber> PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Base64EncodedImage { get; set; } 
    }
}
