

namespace _01.BakingMasterclass
{
    using System;

     public class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());  // for 1 pack
            double eggPrice = double.Parse(Console.ReadLine());    // for 1 egg
            double apronPrice = double.Parse(Console.ReadLine());   // for 1 apron 

            int freeFlourPackedge = (int)students / 5;
                        

            double budgetNeeded = (eggPrice * 10* students) 
                + (flourPrice * (students - freeFlourPackedge)) 
                + (apronPrice * Math.Ceiling(students * 1.2));


            if (budget >= budgetNeeded)
            {
                Console.WriteLine($"Items purchased for {budgetNeeded:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(budgetNeeded - budget):f2}$ more needed.");
            }                    
        }
    }
}
