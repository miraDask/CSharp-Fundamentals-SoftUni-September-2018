

namespace _10.TopNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (SumIsDevisibleBy8(i) && OddDgitIsFounf(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool SumIsDevisibleBy8(int number)
        {
            bool result = false;
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                result = true;
            }

            return result;
        }

        public static bool OddDgitIsFounf(int number)
        {
            bool result = false;

            while (number > 0)
            {
                int temt = number % 10;

                if (temt % 2 != 0)
                {
                    result = true;
                    break;
                }
                else
                {
                    number /= 10;
                }
            }

            return result;
        }
    }
}
