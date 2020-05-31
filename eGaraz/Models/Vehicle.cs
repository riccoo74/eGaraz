using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eGaraz.Models
{
    public class Vehicle : BaseEntity
    {
        [Display(Name = "Marka Pojazdu")]
        [Required(ErrorMessage = "Marka Pojazdu jest wymagana")]
        public string Brand { get; set; }

        [Display(Name = "Model Pojazdu")]
        public string Model { get; set; }

        [Display(Name = "Numer VIN")]
        [Required(ErrorMessage = "Numer VIN jest wymagany")]
        public string VinNum { get; set; }

        [Display(Name = "Pojemność Silnika")]
        public short? EngineCapacity { get; set; }

        [Display(Name = "Moc Silnika")]
        public short? Power { get; set; }

        [Display(Name = "Numer Operacyjny")]
        [Required(ErrorMessage = "Numer Operacyjny jest wymagany")]
        public string OperationalNum { get; set; }

        [Display(Name = "Oznaczenie Taktyczne Pojazdu")]
        [Required(ErrorMessage = "Oznaczenie Taktyczne Pojazdu jest wymagane")]
        public string Mark { get; set; }

        [Display(Name = "Stan Licznika")]
        [Required(ErrorMessage = "Stan Licznika jest wymagany")]
        public int Counter { get; set; }

        [Display(Name = "Rok Produkcji")]
        [Required(ErrorMessage = "Rok Produkcji jest wymagany")]
        public short YearOfProd { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
        public IList<VehicleTrip> VehicleTrips { get; set; }
    }
}
