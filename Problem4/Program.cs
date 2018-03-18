//CONFIRMED from <LazarPanchev>
using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
			//We receive from the console product name in the first line- a string
            string productName = Console.ReadLine();
			/*In the next three lines, we receive volume, energy and sugar content per 100ml.
			as integers*/
            int volume = int.Parse(Console.ReadLine());
            int energyPer100 = int.Parse(Console.ReadLine());
            int sugarPer100 = int.Parse(Console.ReadLine());
			//We calculate the current volume
            double currentVolume = volume / 100.0;
            //Finally we calculate the energy and sugar content for current volume. Print them on the console
            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{energyPer100 * currentVolume}kcal, {sugarPer100*currentVolume}g sugars");
        }
    }
}
