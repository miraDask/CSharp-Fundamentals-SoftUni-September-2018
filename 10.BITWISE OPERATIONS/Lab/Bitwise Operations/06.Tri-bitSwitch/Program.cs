using System;

namespace _06.Tri_bitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 7 << position;
           // mask = ~mask;

            long newNumber = num ^ mask;

            Console.WriteLine(newNumber);

        }
    }
}
