using System;

namespace _03.p_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            num = num >> position;
            int mask = 1 ;

           int bitOfcurrentPosition = mask & num;
            

            Console.WriteLine(bitOfcurrentPosition);
        }
    }
}
