using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelModels
{
    public class StringFunctions
    {
        public string DisplayDateAndTime()
        {


            return DateTime.Now.ToLongDateString();
                
         }

    }

    public static class ExtendStringFunctions
    {
        public static void ShowDayofWeek(this StringFunctions fun)
        {
            Console.WriteLine(DateTime.Now.DayOfWeek);

        }


    }


}
