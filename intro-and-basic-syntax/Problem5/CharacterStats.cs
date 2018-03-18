//CONFIRMED from anavelcheva
using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
			/*We receive from the console four lines with card numbers*/
            int firstDigits = int.Parse(Console.ReadLine());
            int secondDigits = int.Parse(Console.ReadLine());
            int thirdDigits = int.Parse(Console.ReadLine());
            int fourthDigits = int.Parse(Console.ReadLine());
            // We print them on the console using formatting for the zeroes 
            Console.WriteLine($"{firstDigits:d4} {secondDigits:d4} {thirdDigits:d4} {fourthDigits:d4}");

            


        }
    }
}
