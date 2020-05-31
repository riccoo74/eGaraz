using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eGaraz.Models
{
    public class Firemen : BaseEntity
    {
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Imię jest wymagane")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string Surname { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public Gender Gender { get; set; }

        [Display(Name = "PESEL")]
        [Required(ErrorMessage = "PESEL jest wymagany")]
        public string Pesel { get; set; }

        [Display(Name = "Data Urodzenia")]
        [Required(ErrorMessage = "Data Urodzenia jest wymagana")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Syn/Córka")]
        [Required(ErrorMessage = "Podanie imienia ojca/matki jest wymagane")]
        public string Son_Daughter { get; set; }

        [Display(Name = "Ulica")]
        [Required(ErrorMessage = "Ulica jest wymagana")]
        public string Street { get; set; }

        [Display(Name = "Numer Domu")]
        [Required(ErrorMessage = "Numer domu jest wymagany")]
        public string HouseNumber { get; set; } //type string in case for e.g 145B, 12A

        [Display(Name = "Numer lokalu/mieszkania")]
        public short? FlatNumber { get; set; }

        [Display(Name = "Kod Pocztowy")]
        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        public string DigitalCode { get; set; }

        [Display(Name = "Miasto")]
        [Required(ErrorMessage = "Miasto jest wymagane")]
        public string City { get; set; }

        [Display(Name = "Funkcja w OSP")]
        [Required(ErrorMessage = "Funkcja jest wymagana")]
        public string Function { get; set; }

        [Display(Name = "PESEL")]
        [Required(ErrorMessage = "PESEL jest wymagany")]
        public bool Management { get; set; }

        [Required]
        [Display(Name = "Aktywny")]
        public bool Active { get; set; }

        [Display(Name = "Uwagi")]
        public string Comments { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public Driver Driver { get; set; }
        public ICollection<Training> Trainings { get; set; }
        public ICollection<MedicalExamination> MedicalExaminations { get; set; }
        public IList<FiremenTrip> FiremenTrips { get; set; }

    }

    public enum Gender
    {
        Male,
        Female
    }
}
