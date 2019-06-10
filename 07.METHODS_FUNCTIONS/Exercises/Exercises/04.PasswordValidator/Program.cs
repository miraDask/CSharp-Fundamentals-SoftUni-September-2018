

namespace _04.PasswordValidator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string password = Console.ReadLine();
           

            if (!IsInLengthboundaries(password.Length))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!ConsistLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");

            }

            if (!ConsistEnoughDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (IsInLengthboundaries(password.Length) && ConsistLettersAndDigits(password) && ConsistEnoughDigits(password))
            {
                Console.WriteLine("Password is valid");
            }


        }

        public static bool IsInLengthboundaries(int length)
        {
            return length >= 6 && length <= 10 ? true : false;

        }

        public static bool ConsistEnoughDigits(string text)
        {            
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    count++;
                }
            }

                return count >= 2 ? true : false;
              
        }

        public static bool ConsistLettersAndDigits(string text)
        {
            
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetterOrDigit(text[i]))
                {
                    return false;
                }
            }

            return true;
        }

       
    }
}
