using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eGaraz.Models
{
    public class Equipment : BaseEntity
    {
        [Display(Name = "Nazwa Sprzętu")]
        [Required(ErrorMessage = "Nazwa Sprzętu jest wymagana")]
        public string Name { get; set; }

        public int? VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
        public IList<EquipmentTrip> EquipmentTrips { get; set; }
    }
}
