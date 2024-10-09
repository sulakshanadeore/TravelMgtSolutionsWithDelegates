using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelModels
{
    public sealed class Dept
    {
        public int Deptno { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine(Deptno);

        }

    }

   
}
