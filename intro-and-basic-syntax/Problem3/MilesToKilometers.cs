//CONFIRMED from anavelcheva
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {//Read the miles from the console.
            double miles = double.Parse(Console.ReadLine());
            //Convert the miles in kilometers.
            double kilometer = miles * 1.60934;
            //Print the kilometers.
            Console.WriteLine("{0:F2}",kilometer);
        }
    }
}

