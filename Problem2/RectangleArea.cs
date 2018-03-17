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
        {
            double rectWidth = double.Parse(Console.ReadLine());
            double rectHeight = double.Parse(Console.ReadLine());
            double rectArea = rectHeight * rectWidth;
            Console.WriteLine($"{rectArea:F2}");
        }
    }
}