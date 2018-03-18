using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyPer100 = int.Parse(Console.ReadLine());
            int sugarPer100 = int.Parse(Console.ReadLine());
            double volume2 = volume / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyPer100 * volume2}kcal, {sugarPer100*volume2}g sugars");
        }
    }
}
