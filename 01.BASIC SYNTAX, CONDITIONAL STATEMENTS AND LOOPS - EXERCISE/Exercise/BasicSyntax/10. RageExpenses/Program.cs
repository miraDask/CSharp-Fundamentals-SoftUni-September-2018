using System;

namespace _10._RageExpenses
{
    public class Program
    {
        public static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsets = 0;
            int mouses = 0;
            int keyboards = 0;
            int displays = 0;
            

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsets++;
                   
                }

                if (i % 3 == 0)
                {
                    mouses++;
                   
                }

                if ((i % 2 == 0)&&(i % 3 == 0))
                {
                    keyboards++;
                  
                }

            
            }

            displays = keyboards / 2;
                
            
            double expenses = (headsets * headsetPrice) + (mouses * mousePrice) + (keyboards * keyboardPrice) + (displays * displayPrice);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
             
        }
    }
}
