using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            char[] user = userName.ToCharArray();
            string password = String.Empty;

            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                string passInput = Console.ReadLine();

                if (i != 4)
                {

                    if (passInput == password)
                    {
                        Console.WriteLine($"User {userName} logged in.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                    }

                }
                else
                {
                    if (passInput == password)
                    {
                        Console.WriteLine($"User {userName} logged in.");
                    }
                    else
                    {
                        Console.WriteLine($"User {userName} blocked!");
                    }
                }
            }
        }
    }
}
