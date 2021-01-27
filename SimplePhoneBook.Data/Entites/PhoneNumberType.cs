using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplePhoneBook.Data.Entites
{
    [Table(nameof(PhoneNumberType))]
    public class PhoneNumberType : Entity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}