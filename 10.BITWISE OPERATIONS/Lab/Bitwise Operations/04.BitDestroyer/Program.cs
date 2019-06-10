using System;

namespace _04.BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            //num = 1313  ->   ‭010100100001‬
            //p= 5
            //  1 ->           000000000001

            int mask = 1 << position;
            //                 000000100000
            mask = ~ mask;

            //                 111111011111

            //                 010100100001
            //                 111111011111
            //
            int newNumber = num & mask;

            Console.WriteLine(newNumber);
        }
    }
}
