using System;
using System.Numerics;

namespace _08.Snowballs
{
    public class Program
    {
        public static void Main()
        {
            int snowballs = int.Parse(Console.ReadLine());
            
            string result = "";

            BigInteger highestValue = 0;  

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow /snowballTime), snowballQuality);
                
                if ( highestValue <= snowballValue)
                {
                    highestValue = snowballValue;
                    result = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(result);
        }
    }
}
