using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eGaraz.Models
{
    public class Trip : BaseEntity
    {
        [Display(Name = "Data Wyjazdu")]
        [Required(ErrorMessage = "Data Wyjazdu jest wymagana")]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Data Powrotu")]
        [Required(ErrorMessage = "Data Powrotu jest wymagana")]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Godzina Wyjazdu")]
        [Required(ErrorMessage = "Godzina Wyjazdu jest wymagana")]
        public TimeSpan DepartureTime { get; set; }

        [Display(Name = "Godzina Powrotu")]
        [Required(ErrorMessage = "Godzina Powrotu jest wymagana")]
        public TimeSpan ReturnTime { get; set; }

        [Display(Name = "Ilość Przebytych Kilometrów")]
        [Required(ErrorMessage = "Ilość Przebytych Kilometrów jest wymagana")]
        public short KilometersNum { get; set; }

        [Display(Name = "Tytuł Wyjazdu")]
        [Required(ErrorMessage = "Tytuł wyjazdu jest wymagany")]
        public string Title { get; set; }

        [Display(Name = "Opis Wyjazdu")]
        [Required(ErrorMessage = "Opis Wyjazdu jest wymagany")]
        public string Description { get; set; }

        [Display(Name = "Kod Pocztowy")]
        public string DigitalCode { get; set; }

        [Display(Name = "Miejscowość")]
        [Required(ErrorMessage = "Opis Wyjazdu jest wymagany")]
        public string City { get; set; }

        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Display(Name = "Numer posesji")]
        public string PropertyNum { get; set; }

        [Display(Name = "Alarmował SKKM")]
        [Required]
        public bool SkkmAlarm { get; set; }

        [Display(Name = "Dowódca")]
        [Required(ErrorMessage = "Dowódca jest wymagany")]
        public string Commander { get; set; }

        [Display(Name = "Uwagi")]
        public string Comments { get; set; }

        public IList<FiremenTrip> FiremenTrips { get; set; }
        public IList<VehicleTrip> VehicleTrips { get; set; }
        public IList<EquipmentTrip> EquipmentTrips { get; set; }
    }
}
