using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
			//We receive from the console product name in the first line- a string
            string name = Console.ReadLine();
			/*In the next three lines, we receive volume, energy and sugar content per 100ml.
			as integers*/
            int volume = int.Parse(Console.ReadLine());
            int energyPer100 = int.Parse(Console.ReadLine());
            int sugarPer100 = int.Parse(Console.ReadLine());
			//We calculate the current volume
            double volume2 = volume / 100.0;
            //Finally we calculate the energy and sugar content for current volume. Print them on the console
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyPer100 * volume2}kcal, {sugarPer100*volume2}g sugars");
        }
    }
}
