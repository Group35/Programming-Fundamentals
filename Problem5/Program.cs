using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
			/*We receive from the console four lines with card numbers*/
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            // We print them on the console using formatting for the zeroes 
            Console.WriteLine($"{first:d4} {second:d4} {third:d4} {fourth:d4}");

            


        }
    }
}
