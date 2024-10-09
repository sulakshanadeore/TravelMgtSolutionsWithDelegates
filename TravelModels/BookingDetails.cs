using System.Reflection.Metadata;

namespace TravelModels
{
    //travelModels

    public class BookingDetails 
    {
        public int NoOfSeats { get; set; }
        public string FromLoc { get; set; }
        public string ToLoc { get; set; }
        public double RatePerSeat { get; set; }

        public double TotalFare { get; set; }
    }

}