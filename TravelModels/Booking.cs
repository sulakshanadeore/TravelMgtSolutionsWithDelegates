using System.Reflection.Metadata;

namespace TravelModels
{

    //TravelDAO

    public delegate bool BookingAgent(BookingDetails bookingDetails);

    public class Booking  
    {
            
        //event Signature + delegate signature + method signature==typesafety
        public bool Book(BookingDetails bookingDetails)
        {
            return true;
        
        }
        public bool CalculateTotalFare(BookingDetails bookingDetails)
        {
            BookingDetails det=new BookingDetails();
            det.TotalFare=bookingDetails.NoOfSeats * bookingDetails.RatePerSeat;
            Console.WriteLine(det.TotalFare);
            return true;
        }

    }
}
