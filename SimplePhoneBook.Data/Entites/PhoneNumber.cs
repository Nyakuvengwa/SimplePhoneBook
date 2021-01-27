using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplePhoneBook.Data.Entites
{
    [Table(nameof(PhoneNumber))]
    public class PhoneNumber : Entity
    {
        [ForeignKey(nameof(Contact))]
        public int ContactId { get; set; }
        [MaxLength(50)]
        public string Number { get; set; }

        [ForeignKey(nameof(PhoneNumberType))]
        public int PhoneNumberTypeId { get; set; }

        public virtual PhoneNumberType  PhoneNumberType{ get; set;} 
    }
}