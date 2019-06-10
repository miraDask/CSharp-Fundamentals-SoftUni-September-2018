using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            

            for (int i = 1; i <= num; i++)
            {   
                int sum = 0;
                bool isSpecial = false;

                foreach (var digit in i.ToString())
                {
                    sum += digit - '0';
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
