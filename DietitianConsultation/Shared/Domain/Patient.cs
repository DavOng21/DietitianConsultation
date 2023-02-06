using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietitianConsultation.Shared.Domain
{
    public class Patient : BaseDomainModel, IValidatableObject
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
        public string Contact { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            if (DateOfBirth != null)
            {
                if(DateOfBirth >= DateTime.Today)
                {
                    yield return new ValidationResult("DateOfBirth is Invalid", new[] { "DateOfBirth" });
                }
            }
        }
    }
}
