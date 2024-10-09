using System.Globalization;
using TravelModels;



namespace DelegatesDemo
{
    internal class Program
    {
        public static event DoAddSub ev_DoCalculation;

        //public static event BookingAgent ev_BookATicket;
        static void Main(string[] args)
        {
            //Without events
            // Maths m=new Maths();

            // DoAddSub delobj = new DoAddSub(m.Add);
            // DoAddSub delobj1 = new DoAddSub(m.Subtract);

            //DoAddSub d =(DoAddSub)MulticastDelegate.Combine(delobj, delobj1);
            // d.Invoke(20, 10);
            //-----------------------------------------------------------------
            //With events
            Maths m = new Maths();
             DoAddSub delobj = new DoAddSub(m.Add);
             DoAddSub delobj1 = new DoAddSub(m.Subtract);

            ev_DoCalculation += delobj;
            ev_DoCalculation += delobj1;

            ev_DoCalculation(20, 10);


            //Anonymous Methods
            DoDivision obj = delegate (int i, int j) {
                if (j!= 0)
                {
                    int ans = i / j;
                    Console.WriteLine($"The division of {i} divided by {j}= {ans}");
                }
            
            };

            obj(10, 2);
            Console.WriteLine(  "===================================");

            StringFunctions strfun = new StringFunctions();
            string datetimeData=strfun.DisplayDateAndTime();
            Console.WriteLine(datetimeData);
            strfun.ShowDayofWeek();
            Console.WriteLine("----------------------------------------");

            string[] strs = new string[5] {"Hello","Welcome","Good Morning","Good Night", "Bye" };

            string s=strs.FirstOrDefault();
            Console.WriteLine(s);









            //BookingDetails details = new BookingDetails { NoOfSeats = 2, FromLoc = "Pune", ToLoc = "Blr", 
            //    RatePerSeat = 900 };
            //Booking b = new Booking();
            //BookingAgent delobj = new BookingAgent(b.Book);
            //BookingAgent delobj1 = new BookingAgent(b.CalculateTotalFare);

            //BookingAgent combinedBoth=(BookingAgent)MulticastDelegate.Combine(delobj, delobj1);

            //bool ans = combinedBoth(details);



            //  ev_BookATicket += delobj;

            //bool ans=ev_BookATicket(details);
            //Console.WriteLine(ans);
            Console.ReadKey();



        }

        
    }

}
// See https://aka.ms/new-console-template for more information

