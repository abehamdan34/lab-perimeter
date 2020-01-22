using System;

namespace Perimeter_assignement
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomLength, roomWidth, roomHeight;
            string userResponse = "y";

            while (userResponse == "y")
            {
                Console.WriteLine("Welcome to the Grand Circus room detail generator!");

                Console.Write("Enter Length: ");
                roomLength = double.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                roomWidth = double.Parse(Console.ReadLine());

                double area = (roomLength * roomWidth);

                Console.Write("Enter Height: ");
                roomHeight = double.Parse(Console.ReadLine());
                
                double volume = (roomLength * roomWidth * roomHeight);
                Console.WriteLine($"volume: {volume}");


                Console.WriteLine($"area: {area}");

                double peri = 2 * (roomWidth + roomLength);

                Console.WriteLine($"perimeter: {peri}");

                Console.WriteLine("Continue? (y/n)");
                userResponse = Console.ReadLine();
            }



        }
    }
}
