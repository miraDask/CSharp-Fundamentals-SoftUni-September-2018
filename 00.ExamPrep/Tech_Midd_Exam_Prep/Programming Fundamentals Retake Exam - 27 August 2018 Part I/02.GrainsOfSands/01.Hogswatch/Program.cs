using System;

namespace _01.Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int totalPresents = int.Parse(Console.ReadLine());

            int presentsLeft = totalPresents;
            int visitedHomes = 0;
            bool isBackForPresents = false;
            int returnsCount = 0;
            int remainingHomes = homesToVisit;
            int additionalPresents = 0;
            int additionalPresentsTaken = 0;
            int sumOfTakenPresents = 0;
            
            for (int i = 1; i <= homesToVisit; i++)
            {
                int numOfChildren = int.Parse(Console.ReadLine());
                visitedHomes++;
                remainingHomes--;
                additionalPresents = numOfChildren;

                if (numOfChildren <= presentsLeft)
                {
                    presentsLeft -= numOfChildren;
                }
                else
                {
                    
                    isBackForPresents = true;
                    additionalPresentsTaken = (totalPresents / visitedHomes) * remainingHomes + (numOfChildren - presentsLeft);
                    sumOfTakenPresents += additionalPresentsTaken;
                    presentsLeft = additionalPresentsTaken - (numOfChildren - presentsLeft);
                    returnsCount++;
                }

            }

            if (isBackForPresents)
            {
                Console.WriteLine(returnsCount);
                Console.WriteLine(sumOfTakenPresents);
            }
            else
            {
                Console.WriteLine(presentsLeft);
            }
        }
    }
}
