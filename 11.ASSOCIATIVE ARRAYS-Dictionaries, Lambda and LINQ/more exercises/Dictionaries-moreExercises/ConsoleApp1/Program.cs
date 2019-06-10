using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int siteOfCube = int.Parse(Console.ReadLine());

            int areaFigure = 2 * (3 * siteOfCube) + 2 * (5 * siteOfCube);
            

            int area = areaFigure + (4 * siteOfCube);

            Console.WriteLine($"Area is : {area}");
        }
    }
}
