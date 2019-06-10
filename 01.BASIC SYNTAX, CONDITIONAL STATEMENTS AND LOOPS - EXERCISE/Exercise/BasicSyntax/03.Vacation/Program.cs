using System;

namespace _03.Vacation
{
    public class Program
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            string occupation = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();


            double totalPrice = 0;

            if (occupation == "Students")
            {
                if (dayOfTheWeek == "Monday")
                {
                    totalPrice = numberOfPeople * 9.5;
                }
                else if (dayOfTheWeek == "Tuesday")
                {
                    totalPrice = numberOfPeople * 8;
                }
                else if (dayOfTheWeek == "Wednesday")
                {
                    totalPrice = numberOfPeople * 6.85;
                }
                else if (dayOfTheWeek == "Thursday")
                {
                    totalPrice = numberOfPeople * 7.15;
                }
                else if (dayOfTheWeek == "Friday")
                {
                    totalPrice = numberOfPeople * 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    totalPrice = numberOfPeople * 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    totalPrice = numberOfPeople * 10.46;
                }

                if (numberOfPeople >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }

            }

            if (occupation == "Business")
            {

                if (numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;

                }


                if (dayOfTheWeek == "Monday")
                {
                    totalPrice = numberOfPeople * 11.80;
                }
                else if (dayOfTheWeek == "Tuesday")
                {
                    totalPrice = numberOfPeople * 14.50;
                }
                else if (dayOfTheWeek == "Wednesday")
                {
                    totalPrice = numberOfPeople * 12.60;
                }
                else if (dayOfTheWeek == "Thursday")
                {
                    totalPrice = numberOfPeople * 13.20;
                }
                else if (dayOfTheWeek == "Friday")
                {
                    totalPrice = numberOfPeople * 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    totalPrice = numberOfPeople * 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    totalPrice = numberOfPeople * 16;
                    
                }


        
            }


            if (occupation == "Regular")
            {

                if (dayOfTheWeek == "Monday")
                {
                    totalPrice = numberOfPeople * 15;
                }
                else if (dayOfTheWeek == "Tuesday")
                {
                    totalPrice = numberOfPeople * 15;
                }
                else if (dayOfTheWeek == "Wednesday")
                {
                    totalPrice = numberOfPeople * 14.80;
                }
                else if (dayOfTheWeek == "Thursday")
                {
                    totalPrice = numberOfPeople * 13.90;
                }
                else if (dayOfTheWeek == "Friday")
                {
                    totalPrice = numberOfPeople * 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    totalPrice = numberOfPeople * 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    totalPrice = numberOfPeople * 22.50;
                   
                }

                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
                

                

            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
