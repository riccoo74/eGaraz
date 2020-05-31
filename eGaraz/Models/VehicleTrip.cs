
namespace eGaraz.Models
{
    public class VehicleTrip
    {
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
