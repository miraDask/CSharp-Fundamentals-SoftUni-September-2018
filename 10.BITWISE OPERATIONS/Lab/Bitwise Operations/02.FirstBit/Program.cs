using System;

namespace _02.FirstBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());  
            //   2 ---  0010                 0010
            //    1--   0001 ---> 1 << 1 =>  0010 
                                                            
            int mask = 1 << 1;
            int result = number & mask;
            result = result >> 1;

            Console.WriteLine(result);
        }
    }
}
