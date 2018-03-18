//CONFIRMED from anavelcheva
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {//Read from the console the width and height of the reactangle.
            double rectWidth = double.Parse(Console.ReadLine());
            double rectHeight = double.Parse(Console.ReadLine());
            //Calculate the area.
            double rectArea = rectHeight * rectWidth;
            //Print the area.
            Console.WriteLine($"{rectArea:F2}");
        }
    }
}