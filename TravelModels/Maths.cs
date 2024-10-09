using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelModels
{
    public delegate void DoAddSub(int no1,int no2);

    public delegate void DoDivision(int no1,int no2);

    public class Maths
    {

        public void Add(int i, int j)
        {
            Console.WriteLine(i+j);

        }
        public void Subtract(int i, int j) 
        { 
        if(j!=0)

                Console.WriteLine(i -j);
        }
    }
}
