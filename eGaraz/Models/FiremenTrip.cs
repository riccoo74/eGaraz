
namespace eGaraz.Models
{
    public class FiremenTrip
    {
        public int FiremenId { get; set; }
        public Firemen Firemen { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
