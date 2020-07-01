using eGaraz.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eGaraz.Models
{
    public class ApplicationUser  : IdentityUser
    {
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        public override string UserName { get; set; }

        [Required(ErrorMessage = "Adres email jest wymagany")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres e-mail")]
        public override string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Imię jest za długie")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Nazwisko jest za długie")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Płeć jest wymagana")]
        public Gender Gender { get; set; }

        [MaxLength(60, ErrorMessage = "Nazwa miasta jest za długa")]
        public string City { get; set; }

        [MaxLength(100, ErrorMessage = "Adres jest zbyt długi")]
        public string Address { get; set; }

        [RegularExpression("^\\d{2}[- ]{0,1}\\d{3}$", ErrorMessage = "Nieprawidłowy kod pocztowy")]
        public string PostalCode { get; set; }

        [RegularExpression(@"(?<!\w)(\(?(\+|00)?48\)?)?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}(?!\w)", ErrorMessage = "Nieprawidłowy numer telefonu")]
        public override string PhoneNumber { get; set; }

    }
}
