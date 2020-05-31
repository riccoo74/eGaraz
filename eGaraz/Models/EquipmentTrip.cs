
namespace eGaraz.Models
{
    public class EquipmentTrip
    {
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
