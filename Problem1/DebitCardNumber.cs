using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debit_card_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second  = int.Parse(Console.ReadLine());
            int third= int.Parse(Console.ReadLine());
            int four= int.Parse(Console.ReadLine());
            Console.Write("{0:D4} ",first);
            Console.Write("{0:D4} ", second);
            Console.Write("{0:D4} ", third);
            Console.WriteLine("{0:D4}", four);

        }
    }
}